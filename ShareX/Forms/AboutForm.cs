#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2022 ShareX Team

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using ShareX.HelpersLib;
using ShareX.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShareX
{
    public partial class AboutForm : Form
    {
        private EasterEggAboutAnimation easterEgg;
        private bool checkUpdate = false;

        public AboutForm()
        {
            InitializeComponent();
          
            pbLogo.Image = ShareXResources.Logo;
            ShareXResources.ApplyTheme(this);

#if STEAM
            uclUpdate.Visible = false;
            lblBuild.Text = "Steam build";
            lblBuild.Visible = true;
#elif MicrosoftStore
            uclUpdate.Visible = false;
            lblBuild.Text = "Microsoft Store build";
            lblBuild.Visible = true;
#else
           
         
#endif

            rtbInfo.AppendLine(Resources.AboutForm_AboutForm_Links, FontStyle.Bold, 13);
            rtbInfo.AppendLine($@"{Resources.AboutForm_AboutForm_Website}: {Links.Website}
{Resources.AboutForm_AboutForm_Changelog}: {Links.Changelog}
{Resources.AboutForm_AboutForm_Privacy_policy}: {Links.PrivacyPolicy}
", FontStyle.Regular);

            rtbInfo.AppendLine(Resources.AboutForm_AboutForm_Team, FontStyle.Bold, 13);
            rtbInfo.AppendLine($@"Jaex: {Links.Jaex}
McoreD: {Links.McoreD}
Blaine Palmer: {"https://thepalmerstudio.net"}
", FontStyle.Regular);

            rtbInfo.AppendLine(Resources.AboutForm_AboutForm_Translators, FontStyle.Bold, 13);
            rtbInfo.AppendLine($@"{Resources.AboutForm_AboutForm_Language_tr}: https://github.com/Jaex
{Resources.AboutForm_AboutForm_Language_de}: https://github.com/Starbug2 & https://github.com/Kaeltis
{Resources.AboutForm_AboutForm_Language_fr}: https://github.com/nwies & https://github.com/Shadorc
{Resources.AboutForm_AboutForm_Language_zh_CH}: https://github.com/jiajiechan
{Resources.AboutForm_AboutForm_Language_hu}: https://github.com/devBluestar
{Resources.AboutForm_AboutForm_Language_ko_KR}: https://github.com/123jimin
{Resources.AboutForm_AboutForm_Language_es}: https://github.com/ovnisoftware
{Resources.AboutForm_AboutForm_Language_nl_NL}: https://github.com/canihavesomecoffee
{Resources.AboutForm_AboutForm_Language_pt_BR}: https://github.com/RockyTV & https://github.com/athosbr99
{Resources.AboutForm_AboutForm_Language_vi_VN}: https://github.com/thanhpd
{Resources.AboutForm_AboutForm_Language_ru}: https://github.com/L1Q
{Resources.AboutForm_AboutForm_Language_zh_TW}: https://github.com/alantsai
{Resources.AboutForm_AboutForm_Language_it_IT}: https://github.com/pjammo
{Resources.AboutForm_AboutForm_Language_uk}: https://github.com/6c6c6
{Resources.AboutForm_AboutForm_Language_id_ID}: https://github.com/Nicedward
{Resources.AboutForm_AboutForm_Language_es_MX}: https://github.com/absay
{Resources.AboutForm_AboutForm_Language_fa_IR}: https://github.com/pourmand1376
{Resources.AboutForm_AboutForm_Language_pt_PT}: https://github.com/FarewellAngelina
{Resources.AboutForm_AboutForm_Language_ja_JP}: https://github.com/kanaxx
{Resources.AboutForm_AboutForm_Language_ro}: https://github.com/Edward205
{Resources.AboutForm_AboutForm_Language_pl}: https://github.com/RikoDEV
", FontStyle.Regular);

            rtbInfo.AppendLine(Resources.AboutForm_AboutForm_Credits, FontStyle.Bold, 13);
            rtbInfo.AppendLine(@"Json.NET: https://github.com/JamesNK/Newtonsoft.Json
SSH.NET: https://github.com/sshnet/SSH.NET
Icons: http://p.yusukekamiyamane.com
ImageListView: https://github.com/oozcitak/imagelistview
FFmpeg: https://www.ffmpeg.org
Recorder devices: https://github.com/rdp/screen-capture-recorder-to-video-windows-free
FluentFTP: https://github.com/robinrodricks/FluentFTP
Steamworks.NET: https://github.com/rlabrecque/Steamworks.NET
ZXing.Net: https://github.com/micjahn/ZXing.Net
MegaApiClient: https://github.com/gpailler/MegaApiClient
Inno Setup Dependency Installer: https://github.com/DomGries/InnoDependencyInstaller
Blob Emoji: http://blobs.gg
", FontStyle.Regular);

            rtbInfo.AppendText("Thank you for using PShare!", FontStyle.Bold, 13);

          
        }

        private async void AboutForm_Shown(object sender, EventArgs e)
        {
            productname.Text = "PShare " + Application.ProductVersion + " Reverse";
            this.ForceActivate();

           
         
        }

        private void pbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hehe", "Message");
        }

        private void rtb_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            URLHelpers.OpenURL(e.LinkText);
        }

        private void btnShareXLicense_Click(object sender, EventArgs e)
        {
            FileHelpers.OpenFile(FileHelpers.GetAbsolutePath("Licenses\\ShareX_license.txt"));
        }

        private void btnLicenses_Click(object sender, EventArgs e)
        {
            FileHelpers.OpenFolder(FileHelpers.GetAbsolutePath("Licenses"));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            if (Environment.Is64BitOperatingSystem == true) {
                lblarchitecture.Text = "Architecture: 64 Bit " + ", Windows Version: " + Environment.OSVersion.Version + ", Platform: " + Environment.OSVersion.Platform;
                    }
        }

        private void rtbInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://getsharex.com");
        }

        private void checkforupdates_Click(object sender, EventArgs e)
        {
            DownloaderForm downloader = new DownloaderForm("https://eskom.blainewpalmer.com/download/pshare/latestversion.exe", "latestversion.exe");
            downloader.ShowDialog();
        }
    }
}