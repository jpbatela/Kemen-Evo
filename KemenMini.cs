using System;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using log4net;
using System.Runtime.InteropServices;

namespace kemen
{
 
  public partial class KemenMini : Form
  {

    private kemen kmnWnd;
    private NameValueCollection cnfValues = ConfigurationManager.AppSettings;
    private ILog log = log4net.LogManager.GetLogger(typeof(kemen));
    private Thread threadKemenMonitor = null;
    private bool seguir = true;
    private Boolean transparente = false;
    private int indice = 1;
    
   
    public KemenMini(kemen kwnd, int indx)
    {
      InitializeComponent();
      this.kmnWnd = kwnd; 
      this.Text = kwnd.Text;
      this.indice = indx;
      InitializeKemenMini();
     
      
    }
    protected override void OnLoad(EventArgs e)
    {
      var screen = Screen.FromPoint(this.Location);
      this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Top + this.indice * this.Height+40);
      //this.TopMost = true;
      base.OnLoad(e);
    }
    private void InitializeKemenMini() {
      threadKemenMonitor = new Thread(this.executeKemenMonitor);
      threadKemenMonitor.Start();
    }

    private void executeKemenMonitor()
    {
      this.Activate();
      while (seguir)
      {
        try{
          this.lblPeso.Text = this.kmnWnd.getLblPesoValue();
          this.lblUltimo.Text = this.kmnWnd.getLblUltimoPesoValue();
          this.btnED1.BackColor = this.kmnWnd.getED1Value();
          this.btnED2.BackColor = this.kmnWnd.getED2Value();
          this.btnED3.BackColor = this.kmnWnd.getED3Value();
          this.btnED4.BackColor = this.kmnWnd.getED4Value();
          this.pictureBox1.BackColor = this.kmnWnd.getPibConValue ();
          if (this.kmnWnd.getHayAlarma())
          {
            picAlarmON.Visible = true;
            picAlarmOFF.Visible = false;
          } 
          else 
          {
            picAlarmON.Visible = false;
            picAlarmOFF.Visible = true;
          }
        }                                                      
        catch (Exception ex) {
          log.Error("Error en modulo MINI thread KemenMonitor" + ex.Message);
        }
        finally
        {
          Thread.Sleep(250);
        }
      } //while (seguir)
      Thread.Sleep(150);
      this.kmnWnd.WindowState = FormWindowState.Normal;    //BTL
      log.Info("Finalizado thread PiMonitor.");
    }

    private void KemenMini_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.seguir = false;
      this.kmnWnd.setMiniEnabled(true); //BTL
      Thread.Sleep(1000);
      
      //this.threadKemenMonitor.Abort();
     // this.threadKemenMonitor.Join();
    }

    private void lblPeso_Click(object sender, EventArgs e)
    {
      if (transparente == true)
      {
        this.Opacity = 100;
        transparente = false;
      }
      else
      {
        this.Opacity = 0.5;
        transparente = true;
      }

      this.Validate();
    }

    private void lblPeso_MouseEnter(object sender, EventArgs e)
    {
      lblPeso.Cursor  = Cursors.Hand;

    }
  }
}
