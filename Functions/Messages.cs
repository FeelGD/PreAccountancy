using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreAccountancy.Functions
{
    class Messages
    {
        frmMain messageForm = new frmMain();
        public void NewRecord(string Message)
        {
            messageForm.Message("Yeni Kayıt Girişi", Message);
           /* MessageBox.Show(Message, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }
        public DialogResult Delete()
        {
            return MessageBox.Show("Seçili kalıcı olarak silinecektir\n Silme işlemini onaylıyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }


        public DialogResult Update()
        {
            return MessageBox.Show("Seçili kalıcı olarak güncellenecektir.\n Güncelleme işlemini onaylıyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        public void Update(bool Updates)
        {
            messageForm.Message("Kayıt güncellenmiştir.", "Kayıt Güncelleme");
            /*MessageBox.Show("Kayıt güncellenmiştir.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }
        public void Error(Exception Error)
        {

            messageForm.Message("Hata Oluştu", Error.Message);
           /* MessageBox.Show(Error.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
        }
        public void OpenForm(string FormName)
        {
            messageForm.Message("", FormName + " formu açıldı.");
            
        }
        public void CloseForm(string FormName)
        {
            messageForm.Message("", FormName + " formu kapatıldı.");

        }
    }
}
