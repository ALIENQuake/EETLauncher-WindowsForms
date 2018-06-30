using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EETLauncher {
    public partial class EETLauncherSettings : Form {
        public EETLauncherSettings() {
            InitializeComponent();
        }
        private readonly EETLauncherMain StartForm;
        public EETLauncherSettings( Form callingForm ) {
            StartForm = callingForm as EETLauncherMain;
            InitializeComponent();
        }
        public static bool GetProcesExitState( Process Process ) {
            try {
                return Process.ExitCode == 0;
            } catch ( Exception ex )
            {
                File.AppendAllText( Environment.SpecialFolder.ApplicationData + @"\EETLauncher.log", Convert.ToString(ex.Message) + Environment.NewLine);
                return false;
            }
        }
        public string SetEETLauncherSettingsLbChangeguiText {
            get => EETLauncherSettings_LB_CHANGEGUI.Text;
            set => EETLauncherSettings_LB_CHANGEGUI.Text = value;
        }
        public string SetEETLauncherSettingsLCurrentGuiText {
            get => EETLauncherSettings_L_CurrentGUI.Text;
            set => EETLauncherSettings_L_CurrentGUI.Text = value;
        }
        private void EETLauncherSettings_LB_BACK_Click( object sender, EventArgs e ) {
            StartForm.Location = Location;
            StartForm.SetFormVisiblility = true;
            Close();
            Dispose();
        }

        private void EETLauncherSettings_Load( object sender, EventArgs e ) {
            Location = StartForm.SetFormLocation;
            StartForm.SetFormVisiblility = false;
            foreach ( Control control in Controls ) {
                if ( !StringExtensions.ContainsIgnoreCase( control.Name, "Log" ) ) {
                    control.Font = Global.FradmcnRegular;
                }
            }
            Global.SetEETLauncherSettingsGuiState( Global.GetEETGUI(), this );
        }

        private void EETLauncherSettings_LB_OpenEETBaldurLua_Click( object sender, EventArgs e ) {
            if ( Global.TestEETBaldurLua() ) {
                Process.Start( Global.EETBaldurLua );
            } else {
                EETLauncherSettings_TB_Log.Visible = true;
                EETLauncherSettings_TB_Log.Text = @"Please start EET once to create Baldur.lua";
            }
        }

        private async void EETLauncherSettings_LB_CHANGEGUI_Click( object sender, EventArgs e )
        {
            EETLauncherSettings_LB_CHANGEGUI.Enabled = false;
            EETLauncherSettings_LB_BACK.Enabled = false;
            EETLauncherSettings_L_CurrentGUI.ForeColor = Color.White;
            EETLauncherSettings_L_CurrentGUI.Text = @"CURRENT GUI: ???";

            var GUI = Global.GetEETGUI( true );
            var ps0 = new Process { StartInfo = Global.SetEETGUI( GUI ) };

            try {
				// because we want to target .NET 4.0, we are using TaskEx.Run from Microsoft.Bcl.Async instead of default Task.Run from .NET Framework 4.5
				var result = await TaskEx.Run( () => {
                    ps0.Start();
                    ps0.WaitForExit();
                    return ps0;
                });
                var state = GetProcesExitState( result );
                if ( state ) {
                    Global.SetEETLauncherSettingsGuiState( Global.GetEETGUI(), this );
                    EETLauncherSettings_L_CurrentGUI.ForeColor = Color.Green;
                    EETLauncherSettings_LB_CHANGEGUI.Enabled = true;
                    EETLauncherSettings_LB_BACK.Enabled = true;
                }
                if ( state == false ) {
                    EETLauncherSettings_L_CurrentGUI.ForeColor = Color.Red;
                }
            } catch ( Exception ex ) {
                File.AppendAllText( Environment.SpecialFolder.ApplicationData + @"\EETLauncher.log", Convert.ToString( ex.Message ) + Environment.NewLine );
            }
        }

        private void EETLauncherSettings_LB_OpenEETBaldurLua_MouseHover( object sender, EventArgs e ) {
            ( (Label) sender ).ForeColor = Color.Orange;
        }
        private void EETLauncherSettings_LB_OpenEETBaldurLua_MouseLeave( object sender, EventArgs e ) {
            ( (Label) sender ).ForeColor = Color.White;
        }
        private void EETLauncherSettings_LB_CHANGEGUI_MouseHover( object sender, EventArgs e ) {
            ( (Label) sender ).ForeColor = Color.Orange;
        }
        private void EETLauncherSettings_LB_CHANGEGUI_MouseLeave( object sender, EventArgs e ) {
            ( (Label) sender ).ForeColor = Color.White;
        }
        private void EETLauncherSettings_LB_BACK_MouseHover( object sender, EventArgs e ) {
            ( (Label) sender ).ForeColor = Color.Orange; 
        }
        private void EETLauncherSettings_LB_BACK_MouseLeave( object sender, EventArgs e ) {
            ( (Label) sender ).ForeColor = Color.White;
        }

        private void EETLauncherSettings_MouseDown( object sender, MouseEventArgs e ) {
            User32.ReleaseCapture();
            User32.SendMessage( Handle, User32.WmNclbuttondown, User32.HtCaption, 0 );
        }
        private void EETLauncherSettings_PB_Logo_MouseDown( object sender, MouseEventArgs e ) {
            User32.ReleaseCapture();
            User32.SendMessage( Handle, User32.WmNclbuttondown, User32.HtCaption, 0 );
        }
        private void BWorker1_DoWork( object sender, System.ComponentModel.DoWorkEventArgs e ) {

        }
    }
}
