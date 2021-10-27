using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonDemo
{
    public partial class Controller : Form
    {
        private Logger m_Logger;
        public Controller(Logger logger)
        {
            this.m_Logger = logger;
            InitializeComponent();
        }

        private void button1_click(object sender, EventArgs e)
        {
            m_Logger.Log("Pulsante cliccato!");
        }

        private void button1_enter(object sender, EventArgs e)
        {
            m_Logger.Log("Il pulsante e' focalizzato!");
        }

        private void button1_leave(object sender, EventArgs e)
        {
            m_Logger.Log("Il pulsante non e' piu' focalizzato!");
        }

        private void button1_styleChange(object sender, EventArgs e)
        {
            m_Logger.Log("Stile pulsante cambiato!");
        }

        private void button1_dragDrop(object sender, DragEventArgs e)
        {
            m_Logger.Log("Oggetto rilasciato sul pulsante!");
        }

        private void button1_dragEnter(object sender, DragEventArgs e)
        {
            m_Logger.Log("Oggetto entrato nell'area del pulsante!");
        }

        private void button1_dragLeave(object sender, EventArgs e)
        {
            m_Logger.Log("Oggetto uscito dall'area del pulsante!");
        }

        private void button1_resized(object sender, EventArgs e)
        {
            m_Logger.Log("Pulsante ridimensionato!");
        }

        private void button1_mouseDown(object sender, MouseEventArgs e)
        {
            m_Logger.Log("Pulsante mouse premuto sul pulsante!");
        }

        private void button1_mouseEnter(object sender, EventArgs e)
        {
            m_Logger.Log("Puntatore mouse entrato nell'area del pulsante!");
        }

        private void button1_mouseHover(object sender, EventArgs e)
        {
            m_Logger.Log("Puntatore mouse fermo sopra all'area del pulsante!");
        }

        private void button1_mouseLeave(object sender, EventArgs e)
        {
            m_Logger.Log("Puntatore mouse uscito dall'area del pulsante!");
        }

        private void button1_mouseMove(object sender, MouseEventArgs e)
        {
            m_Logger.Log("Puntatore mouse spostato sopra all'area del pulsante!");
        }

        private void button1_mouseUp(object sender, MouseEventArgs e)
        {
            m_Logger.Log("Pulsante mouse rilasciato sul pulsante!");
        }

        private void button1_autoSizeChanged(object sender, EventArgs e)
        {
            m_Logger.Log("Dimensione pulsante cambiata automaticamente!");
        }

        private void button1_dragOver(object sender, DragEventArgs e)
        {
            m_Logger.Log("Oggetto portato fuori dall'area del pulsante!");
        }

        private void Controller_Load(object sender, EventArgs e)
        {
            m_Logger.Log("La form del controllo si sta caricando!");
        }

        private void Controller_Shown(object sender, EventArgs e)
        {
            m_Logger.Log("La form del controllo e' stata mostrata all'utente!");
        }

        private void Controller_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_Logger.Log("La form del controllo si sta' chiudendo!");
        }

        private void Controller_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_Logger.Log("La form del controllo si e' chiusa!");
            MessageBox.Show("Il programma e' terminato!");
        }

        private void Controller_ControlAdded(object sender, ControlEventArgs e)
        {
            m_Logger.Log("Aggiunto controllo alla form!");
        }
    }
}
