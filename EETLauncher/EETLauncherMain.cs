using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EETLauncher {

    public partial class EETLauncherMain : Form {
        public EETLauncherMain() {
            InitializeComponent();
        }
        public Point SetFormLocation {
            get => Location;
            set => Location = value;
        }
        public bool SetFormVisiblility {
            get => Visible;
            set => Visible = value;
        }

        public void DisableEETLauncherMainLb() {
            EETLauncherMain_LB_PLAY.Visible = false;
            EETLauncherMain_LB_SETTINGS.Visible = false;
            EETLauncherMain_LB_UPDATES.Visible = false;
            EETLauncherMain_LB_README.Visible = false;
        }

        private void EETLauncherMain_Load( object sender, EventArgs e ) {
            // nice code but not fot the begging of c# journey :P
            //Controls.OfType<Control>().Where( c => c.Name != null & !StringExtensions.ContainsIgnoreCase( c.Name, "Log" ) ).ToList().ForEach( c => c.Font = fradmcnRegular );

            // "Turkey test" dosen't affect this case
            // var culture = new CultureInfo( "en-US" ); 
            //  if ( culture.CompareInfo.IndexOf( control.Name, "Log", CompareOptions.IgnoreCase ) == -1 )

            foreach ( Control control in Controls ) {
                if ( !StringExtensions.ContainsIgnoreCase( control.Name, "Log" ) ) {
                    control.Font = Global.FradmcnRegular;
                }
            }
            if ( Global.TestBG2EEDirectory() ) {
                if ( Global.TestEETInstalled() ) return;
                DisableEETLauncherMainLb();
                EETLauncherMain_TB_Log.Visible = true;
                EETLauncherMain_TB_Log.Text = @"EET not detected";
            } else {
                DisableEETLauncherMainLb();
                EETLauncherMain_TB_Log.Visible = true;
                EETLauncherMain_TB_Log.Text = @"Please put EETLanucher.exe inside BG2EE directory";
            }
        }

        private void EETLauncherMain_LB_PLAY_Click( object sender, EventArgs e ) {
            Process.Start( Global.ScriptPatch + @"\Baldur.exe" );
            Close();
            Dispose();
        }
        private void EETLauncherMain_LB_SETTINGS_Click( object sender, EventArgs e ) {
            EETLauncherSettings eetLauncherSettings = new EETLauncherSettings( this );
            eetLauncherSettings.Show();
        }

        private void EETLauncherMain_LB_HOMEPAGE_Click( object sender, EventArgs e ) {
            Process.Start( "http://gibberlings3.net/forums/index.php?showforum=195" );
        }
        private void EETLauncherMain_LB_README_Click( object sender, EventArgs e ) {
            if ( Global.TestEETReadme() ) {
                Process.Start(@"EET\Readme-EET.html");
                return;
            }
            EETLauncherMain_TB_Log.Visible = true;
            EETLauncherMain_TB_Log.Text = @"EET Readme file was not found";
        }
        private void EETLauncherMain_LB_EXIT_Click( object sender, EventArgs e ) {
            Close();
            Dispose();
        }

        private void EETLauncherMain_MouseDown( object sender, MouseEventArgs e ) {
            User32.ReleaseCapture();
            User32.SendMessage( Handle, User32.WmNclbuttondown, User32.HtCaption, 0 );
        }
        private void EETLauncherMain_PB_Logo_MouseDown( object sender, MouseEventArgs e ) {
            User32.ReleaseCapture();
            User32.SendMessage( Handle, User32.WmNclbuttondown, User32.HtCaption, 0 );
        }

        private void EETLauncher_LB_MouseHover( object sender, EventArgs e ) {
            ( (Label) sender ).ForeColor = Color.Orange;
        }
        private void EETLauncher_LB_MouseLeave( object sender, EventArgs e ) {
            ( (Label) sender ).ForeColor = Color.White;
        }
    }

    public class Global {
        public static string ScriptPatch = Path.GetDirectoryName( Application.ExecutablePath );
        public static string MyDocuments = Environment.GetFolderPath( Environment.SpecialFolder.MyDocuments );
        public static string EETBaldurLua = MyDocuments + @"\Baldur's Gate - Enhanced Edition Trilogy\Baldur.lua";
        public static Font FradmcnRegular = new Font( "Franklin Gothic Demi Cond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238 );

        public static bool TestEETBaldurLua()
        {
            return File.Exists( EETBaldurLua );
        }
        public static bool TestBG2EEDirectory()
        {
            return File.Exists( ScriptPatch + @"\data\Hexxat.bif" );
        }
        public static bool TestEETInstalled()
        {
            return File.Exists( ScriptPatch + @"\Override\EET.Flag" );
        }
        public static bool TestEETReadme()
        {
            return File.Exists( ScriptPatch + @"\EET\readme-EET.html" );
        }
        public static string GetEETGUI( bool Reverse = false )
        {
            string EETGUI = "";
            var dataFile = File.ReadAllLines( ScriptPatch + @"\weidu.log" ).ToList();
            
            foreach ( var line in dataFile ) {
                if ( StringExtensions.ContainsIgnoreCase( line[0].ToString(), "/" ) ) continue;
                EETGUI = StringExtensions.ContainsIgnoreCase( line, "EET_GUI.tp2" ) ? "SoD" : "BG2";
            }
            switch ( EETGUI ) {
                case "BG2":
                    return Reverse ? "SoD" : "BG2"; 
                case "SoD":
                    return Reverse ? "BG2" : "SoD";
                default:
                    return "";
            }
        }
        public static void SetEETLauncherSettingsGuiState( string EETGUI, EETLauncherSettings EETLauncherSettings ) {
            switch ( EETGUI ) {
                case "BG2":
                    EETLauncherSettings.SetEETLauncherSettingsLbChangeguiText = "CHANGE to SoD";
                    EETLauncherSettings.SetEETLauncherSettingsLCurrentGuiText = "CURRENT GUI: BG2";
                    break;
                case "SoD":
                    EETLauncherSettings.SetEETLauncherSettingsLbChangeguiText = "CHANGE to BG2";
                    EETLauncherSettings.SetEETLauncherSettingsLCurrentGuiText = "CURRENT GUI: SoD";
                    break;
            }
        }

        public static ProcessStartInfo SetProcessStartInfo( string FileName, dynamic ArgumentList ) {
            return new ProcessStartInfo {
                WorkingDirectory = Path.GetDirectoryName( Application.ExecutablePath ) ?? throw new InvalidOperationException(),
                Arguments = (string)String.Join( " ", ArgumentList ),
                FileName = FileName,
                CreateNoWindow = true,
                UseShellExecute = false
            };
        }

        public static ProcessStartInfo SetEETGUI( string GUI ) {
            List<string> procArgList = new List<string>();
            switch ( GUI ) {
                case "BG2": {
                    procArgList.Add( "--uninstall" );
                    break;
                }
                case "SoD": {
                    procArgList.Add( "--force-install 0" );
                    break;
                }
            }

            procArgList.AddRange( new[] { "--noautoupdate", "--no-exit-pause" } );

            var FileName = @"setup-EET_gui.exe";
            var StartInfo = SetProcessStartInfo( FileName , procArgList );
            return StartInfo;
        }
    }

    public static class StringExtensions { // not included as default in .NET ?
        public static bool ContainsIgnoreCase( string source, string toCheck, StringComparison compare = StringComparison.OrdinalIgnoreCase ) {
            if ( source == null ) return false;
            return source.IndexOf( toCheck, compare ) >= 0;
        }
    }

    public class User32 {
        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport( "user32.dll" )]
        public static extern int SendMessage( IntPtr hWnd,
            int msg, int wParam, int lParam );

        [DllImport( "user32.dll" )]
        public static extern bool ReleaseCapture();
    }
}
