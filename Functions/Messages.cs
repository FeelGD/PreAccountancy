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
        public void NewRecord(string Message)
        {
            System.Windows.Forms.MessageBox.Show(Message, "Yeni Kayıt Girişi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
        public DialogResult Delete()
        {
            return MessageBox.Show("Seçili kalıcı olarak silinecektir\n Silme işlemini onaylıyor musunuz=", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }


        public DialogResult Update()
        {
            return MessageBox.Show("Seçili kalıcı olarak güncellenecektir.\n Güncelleme işlemini onaylıyor musunuz=", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        public void Update(bool Updates)
        {
            MessageBox.Show("Kayıt güncellenmiştir.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Error(Exception Error)
        {
            MessageBox.Show(Error.Message,"Hata Oluştu",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
