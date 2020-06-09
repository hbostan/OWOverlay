using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace controller {
  public partial class Form1 : Form {

    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    [DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();

    public class Scores {
      public int win { get; set; }
      public int lose { get; set; }
      public int draw { get; set; }
      public int sr { get; set; }
    }

    Scores scores;
    public Form1() {
      InitializeComponent();
    }

    public void LoadJson() {
      if(!File.Exists("score.json")) {
        Scores s = new Scores();
        File.WriteAllText("score.json", JsonConvert.SerializeObject(s, Formatting.Indented));
      }
      using(StreamReader r = new StreamReader("score.json")) {
        string json = r.ReadToEnd();
        scores = JsonConvert.DeserializeObject<Scores>(json);
      }
    }
    private void Form1_Load(object sender, EventArgs e) {
      LoadJson();
      this.tb_win_count.Text = scores.win+" ";
      this.tb_lose_count.Text = scores.lose + " ";
      this.tb_draw_count.Text = scores.draw + " ";
      this.tb_sr_count.Text = scores.sr + " ";
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e) {
      if(e.Button == MouseButtons.Left) {
        ReleaseCapture();
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
      }
    }

    private void btn_quit_Click(object sender, EventArgs e) {
      Close();
    }

    private void btn_click_handler(object sender, EventArgs e) {
      string button_name = ((Button)sender).Name;
      if(button_name.Equals("btn_win_inc")) {
        scores.win += 1;
        this.tb_win_count.Text = scores.win + " ";
      }
      if(button_name.Equals("btn_win_dec")) {
        scores.win -= 1;
        this.tb_win_count.Text = scores.win + " ";
      }
      if(button_name.Equals("btn_lose_inc")) {
        scores.lose += 1;
        this.tb_lose_count.Text = scores.lose + " ";
      }
      if(button_name.Equals("btn_lose_dec")) {
        scores.lose -= 1;
        this.tb_lose_count.Text = scores.lose + " ";
      }
      if(button_name.Equals("btn_draw_inc")) {
        scores.draw += 1;
        this.tb_draw_count.Text = scores.draw + " ";
      }
      if(button_name.Equals("btn_draw_dec")) {
        scores.draw -= 1;
        this.tb_draw_count.Text = scores.draw + " ";
      }
      File.WriteAllText("score.json", JsonConvert.SerializeObject(scores, Formatting.Indented));
      Console.WriteLine(JsonConvert.SerializeObject(scores, Formatting.Indented));
    }

    private void TextBoxKeyUp(object sender, KeyEventArgs e) {
      if(e.KeyCode == Keys.Enter) {
        string tb_name = ((TextBox)sender).Name;
        if(tb_name.Equals("tb_sr_count")) {
          btn_sr_set_Click(null, null);
        }
        if(tb_name.Equals("tb_win_count")) {
          setTextbox((TextBox)sender, 0);
        }
        if(tb_name.Equals("tb_lose_count")) {
          setTextbox((TextBox)sender, 1);
        }
        if(tb_name.Equals("tb_draw_count")) {
          setTextbox((TextBox)sender, 2);
        }
        ((TextBox)sender).SelectionStart = tb_sr_count.Text.Length;
        ((TextBox)sender).SelectionLength = 0;
        //sr_label.Focus();
        e.Handled = true;
      }
    }

    private void setTextbox(TextBox sender, int wld) {
      int parsed = -1;
      try {
        parsed = Int32.Parse(sender.Text.Trim());
      } catch(FormatException) {
        Console.WriteLine($"Unable to parse '{sender.Text.Trim()}'");
        switch(wld) {
          case 0:
            sender.Text = scores.win + " ";
            break;
          case 1:
            sender.Text = scores.lose + " ";
            break;
          case 2:
            sender.Text = scores.draw + " ";
            break;
        }
        return;
      }
      if(parsed > 0 && parsed < 9999) {
        switch(wld) {
          case 0:
            scores.win = parsed;
            sender.Text = scores.win + " ";
            break;
          case 1:
            scores.lose = parsed;
            sender.Text = scores.lose + " ";
            break;
          case 2:
            scores.draw = parsed;
            sender.Text = scores.draw + " ";
            break;
        }
        File.WriteAllText("score.json", JsonConvert.SerializeObject(scores, Formatting.Indented));
        Console.WriteLine(JsonConvert.SerializeObject(scores, Formatting.Indented));
      } else {
        switch(wld) {
          case 0:
            sender.Text = scores.win + " ";
            break;
          case 1:
            sender.Text = scores.lose + " ";
            break;
          case 2:
            sender.Text = scores.draw + " ";
            break;
        }
      }
    }

    private void btn_sr_set_Click(object sender, EventArgs e) {
      int parsed = -1;
      try {
        parsed = Int32.Parse(this.tb_sr_count.Text.Trim());
      } catch(FormatException) {
        Console.WriteLine($"Unable to parse '{this.tb_sr_count.Text.Trim()}'");
        this.tb_sr_count.Text = scores.sr + " ";
        return;
      }
      if(parsed > 0 && parsed < 9999) {
        scores.sr = parsed;
        this.tb_sr_count.Text = scores.sr + " ";
        File.WriteAllText("score.json", JsonConvert.SerializeObject(scores, Formatting.Indented));
        Console.WriteLine(JsonConvert.SerializeObject(scores, Formatting.Indented));
      } else {
        this.tb_sr_count.Text = scores.sr + " ";
      }

    }
  }
}
