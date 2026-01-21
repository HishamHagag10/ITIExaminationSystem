using ITIExaminationSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem
{
    public partial class AppForm
    {
        private void ShowAdminDashboard()
        {
            menu.Visible = true;
            dashboardToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAdminDashboardTools();
            welcome_lbl.Text  = "Welcome " + _username;
            noStud_lbl.Text   = _dbManager.GetCount(Tabels.Student).ToString();
            noCrs_lbl.Text    = _dbManager.GetCount(Tabels.Course).ToString();
            noIns_lbl.Text    = _dbManager.GetCount(Tabels.Instructor).ToString();
            noTracks_lbl.Text = _dbManager.GetCount(Tabels.Track).ToString();
        }
        private void hideAdminDashboardTools()
        {
            menu.Visible        = false;
            welcome_pnl.Visible = false;
            stat_pnl.Visible    = false;
            welcome_lbl.Visible = false;
            noStud_lbl.Visible  = false;
            noCrs_lbl.Visible   = false;
            noIns_lbl.Visible   = false;
            noTracks_lbl.Visible= false;
        }
        private void showAdminDashboardTools()
        {
            // hide other tabs
            hideLoginTools();
            menu.Visible        = true;
            welcome_pnl.Visible = true;
            stat_pnl.Visible    = true;
            welcome_lbl.Visible = true;
            noStud_lbl.Visible  = true;
            noCrs_lbl.Visible   = true;
            noIns_lbl.Visible   = true;
            noTracks_lbl.Visible= true;
        }
        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LogOut();
        }
    }
}
