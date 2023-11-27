using XIIRPL2_24_Ticketing.MasterForm;

namespace XIIRPL2_24_Ticketing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //FrmLogin FrmLogin = new FrmLogin();
            //FrmLogin.Show();
            FrmMasterBandara bandara = new FrmMasterBandara();
            bandara.Show();
            //FrmMasterMaskapai maskapai = new FrmMasterMaskapai();
            //maskapai.Show();
            //FrmMasterKodePromo kodepromo = new FrmMasterKodePromo();
            //kodepromo.Show();
            //FrmMasterJadwalPenerbangan jadwalpenerbangan = new FrmMasterJadwalPenerbangan();
            //jadwalpenerbangan.Show();
            Application.Run();
        }
    }
}