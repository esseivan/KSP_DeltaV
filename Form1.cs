// Decompiled with JetBrains decompiler
// Type: DeltaVCalculator.Form1
// Assembly: DeltaVCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 56F2D66B-CDFE-421B-956B-986387DF24C7
// Assembly location: xxxxx

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DeltaVCalculator
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private double DeltaVValue;
    private char output;
    private IContainer components;

    internal virtual TableLayoutPanel TableLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox DeltaV { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button exitButton
    {
      get
      {
        return this._exitButton;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.exitButton_Click);
        Button exitButton1 = this._exitButton;
        if (exitButton1 != null)
          exitButton1.Click -= eventHandler;
        this._exitButton = value;
        Button exitButton2 = this._exitButton;
        if (exitButton2 == null)
          return;
        exitButton2.Click += eventHandler;
      }
    }

    internal virtual NumericUpDown ISP
    {
      get
      {
        return this._ISP;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ISP_ValueChanged);
        NumericUpDown isp1 = this._ISP;
        if (isp1 != null)
          isp1.ValueChanged -= eventHandler;
        this._ISP = value;
        NumericUpDown isp2 = this._ISP;
        if (isp2 == null)
          return;
        isp2.ValueChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown Mdry
    {
      get
      {
        return this._Mdry;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Mdry_ValueChanged);
        NumericUpDown mdry1 = this._Mdry;
        if (mdry1 != null)
          mdry1.ValueChanged -= eventHandler;
        this._Mdry = value;
        NumericUpDown mdry2 = this._Mdry;
        if (mdry2 == null)
          return;
        mdry2.ValueChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown Mtot
    {
      get
      {
        return this._Mtot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Mtot_ValueChanged);
        NumericUpDown mtot1 = this._Mtot;
        if (mtot1 != null)
          mtot1.ValueChanged -= eventHandler;
        this._Mtot = value;
        NumericUpDown mtot2 = this._Mtot;
        if (mtot2 == null)
          return;
        mtot2.ValueChanged += eventHandler;
      }
    }

    internal virtual Button resetButton
    {
      get
      {
        return this._resetButton;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button resetButton1 = this._resetButton;
        if (resetButton1 != null)
          resetButton1.Click -= eventHandler;
        this._resetButton = value;
        Button resetButton2 = this._resetButton;
        if (resetButton2 == null)
          return;
        resetButton2.Click += eventHandler;
      }
    }

    internal virtual Button saveButton
    {
      get
      {
        return this._saveButton;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        Button saveButton1 = this._saveButton;
        if (saveButton1 != null)
          saveButton1.Click -= eventHandler;
        this._saveButton = value;
        Button saveButton2 = this._saveButton;
        if (saveButton2 == null)
          return;
        saveButton2.Click += eventHandler;
      }
    }

    internal virtual Button loadButton
    {
      get
      {
        return this._loadButton;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        Button loadButton1 = this._loadButton;
        if (loadButton1 != null)
          loadButton1.Click -= eventHandler;
        this._loadButton = value;
        Button loadButton2 = this._loadButton;
        if (loadButton2 == null)
          return;
        loadButton2.Click += eventHandler;
      }
    }

    internal virtual RichTextBox notes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual SaveFileDialog SaveFile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox outputToNotes
    {
      get
      {
        return this._outputToNotes;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.outputToNotes_CheckedChanged);
        CheckBox outputToNotes1 = this._outputToNotes;
        if (outputToNotes1 != null)
          outputToNotes1.CheckedChanged -= eventHandler;
        this._outputToNotes = value;
        CheckBox outputToNotes2 = this._outputToNotes;
        if (outputToNotes2 == null)
          return;
        outputToNotes2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button notesResetButton
    {
      get
      {
        return this._notesResetButton;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.notesResetButton_Click);
        Button notesResetButton1 = this._notesResetButton;
        if (notesResetButton1 != null)
          notesResetButton1.Click -= eventHandler;
        this._notesResetButton = value;
        Button notesResetButton2 = this._notesResetButton;
        if (notesResetButton2 == null)
          return;
        notesResetButton2.Click += eventHandler;
      }
    }

    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public Form1()
    {
      this.InitializeComponent();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      if (this.SaveFile.ShowDialog() == DialogResult.OK)
      {
        StreamWriter streamWriter = new StreamWriter(this.SaveFile.FileName);
        string text = this.notes.Text;
        streamWriter.WriteLine(text);
        streamWriter.Flush();
        streamWriter.Close();
      }
      this.Close();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      this.Mtot.Value = Decimal.Zero;
      this.Mdry.Value = Decimal.Zero;
      this.ISP.Value = Decimal.Zero;
      this.DeltaV.Text = Conversions.ToString(0);
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      if (this.SaveFile.ShowDialog() != DialogResult.OK)
        return;
      StreamWriter streamWriter = new StreamWriter(this.SaveFile.FileName);
      string text = this.notes.Text;
      streamWriter.WriteLine(text);
      streamWriter.Flush();
      streamWriter.Close();
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      if (this.OpenFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      StreamReader streamReader = new StreamReader(this.OpenFileDialog1.FileName);
      this.notes.Text = streamReader.ReadToEnd();
      streamReader.Close();
    }

    private void outputToNotes_CheckedChanged(object sender, EventArgs e)
    {
      if (this.outputToNotes.Checked)
        this.output = '1';
      else
        this.output = '0';
    }

    private void Mtot_ValueChanged(object sender, EventArgs e)
    {
      if (Decimal.Compare(this.Mdry.Value, Decimal.Zero) > 0 & Decimal.Compare(this.ISP.Value, Decimal.Zero) > 0)
        this.DeltaVCalculate();
      else
        this.DeltaV.Text = Conversions.ToString(0);
    }

    private void Mdry_ValueChanged(object sender, EventArgs e)
    {
      if (Decimal.Compare(this.Mdry.Value, Decimal.Zero) > 0 & Decimal.Compare(this.ISP.Value, Decimal.Zero) > 0)
        this.DeltaVCalculate();
      else
        this.DeltaV.Text = Conversions.ToString(0);
    }

    private void ISP_ValueChanged(object sender, EventArgs e)
    {
      if (Decimal.Compare(this.Mdry.Value, Decimal.Zero) > 0 & Decimal.Compare(this.ISP.Value, Decimal.Zero) > 0)
        this.DeltaVCalculate();
      else
        this.DeltaV.Text = Conversions.ToString(0);
    }

    private void DeltaVCalculate()
    {
      this.DeltaVValue = Math.Log10(Convert.ToDouble(Decimal.Divide(this.Mtot.Value, this.Mdry.Value))) * Convert.ToDouble(this.ISP.Value) * 9.81;
      this.DeltaV.Text = Conversions.ToString(this.DeltaVValue);
      if (Operators.CompareString(Conversions.ToString(this.output), "1", false) != 0)
        return;
      this.notes.AppendText("\r\nDelta V = " + this.DeltaVValue.ToString() + " m/s");
      this.notes.ScrollToCaret();
    }

    private void notesResetButton_Click(object sender, EventArgs e)
    {
      this.notes.Clear();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.outputToNotes = new CheckBox();
      this.Label1 = new Label();
      this.DeltaV = new TextBox();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.Label7 = new Label();
      this.Label8 = new Label();
      this.Label4 = new Label();
      this.exitButton = new Button();
      this.ISP = new NumericUpDown();
      this.Mdry = new NumericUpDown();
      this.Mtot = new NumericUpDown();
      this.resetButton = new Button();
      this.saveButton = new Button();
      this.loadButton = new Button();
      this.notes = new RichTextBox();
      this.OpenFileDialog1 = new OpenFileDialog();
      this.SaveFile = new SaveFileDialog();
      this.notesResetButton = new Button();
      this.Panel1 = new Panel();
      this.Label9 = new Label();
      this.TableLayoutPanel1.SuspendLayout();
      this.ISP.BeginInit();
      this.Mdry.BeginInit();
      this.Mtot.BeginInit();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.TableLayoutPanel1.ColumnCount = 5;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 225f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
      this.TableLayoutPanel1.Controls.Add((Control) this.outputToNotes, 4, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label1, 1, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.DeltaV, 2, 4);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label2, 1, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label3, 1, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label5, 3, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label6, 3, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label7, 3, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label8, 3, 4);
      this.TableLayoutPanel1.Controls.Add((Control) this.Label4, 1, 4);
      this.TableLayoutPanel1.Controls.Add((Control) this.exitButton, 0, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.ISP, 2, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.Mdry, 2, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.Mtot, 2, 1);
      this.TableLayoutPanel1.Controls.Add((Control) this.resetButton, 0, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.saveButton, 0, 3);
      this.TableLayoutPanel1.Controls.Add((Control) this.loadButton, 0, 4);
      this.TableLayoutPanel1.Controls.Add((Control) this.notes, 1, 5);
      this.TableLayoutPanel1.Controls.Add((Control) this.notesResetButton, 4, 2);
      this.TableLayoutPanel1.Controls.Add((Control) this.Panel1, 0, 0);
      this.TableLayoutPanel1.Dock = DockStyle.Fill;
      this.TableLayoutPanel1.Location = new Point(0, 0);
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 7;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
      this.TableLayoutPanel1.Size = new Size(795, 625);
      this.TableLayoutPanel1.TabIndex = 0;
      this.outputToNotes.Anchor = AnchorStyles.Left;
      this.outputToNotes.AutoSize = true;
      this.outputToNotes.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.outputToNotes.Location = new Point(503, 108);
      this.outputToNotes.Name = "outputToNotes";
      this.outputToNotes.Size = new Size(178, 24);
      this.outputToNotes.TabIndex = 1;
      this.outputToNotes.Text = "Send output to notes";
      this.outputToNotes.UseVisualStyleBackColor = true;
      this.Label1.Anchor = AnchorStyles.Left;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(93, 107);
      this.Label1.Margin = new Padding(3, 3, 3, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(195, 29);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Masse totale [kg]";
      this.DeltaV.Anchor = AnchorStyles.Left;
      this.DeltaV.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.DeltaV.Location = new Point(318, 225);
      this.DeltaV.Name = "DeltaV";
      this.DeltaV.ReadOnly = true;
      this.DeltaV.Size = new Size(119, 29);
      this.DeltaV.TabIndex = 7;
      this.DeltaV.Text = "0";
      this.Label2.Anchor = AnchorStyles.Left;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(93, 147);
      this.Label2.Margin = new Padding(3, 3, 3, 0);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(200, 29);
      this.Label2.TabIndex = 8;
      this.Label2.Text = "Masse à vide [kg]";
      this.Label3.Anchor = AnchorStyles.Left;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(93, 187);
      this.Label3.Margin = new Padding(3, 3, 3, 0);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(83, 29);
      this.Label3.TabIndex = 9;
      this.Label3.Text = "ISP [s]";
      this.Label5.Anchor = AnchorStyles.Left;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.Location = new Point(443, 107);
      this.Label5.Margin = new Padding(3, 3, 3, 0);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(39, 29);
      this.Label5.TabIndex = 15;
      this.Label5.Text = "kg";
      this.Label6.Anchor = AnchorStyles.Left;
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.Location = new Point(443, 147);
      this.Label6.Margin = new Padding(3, 3, 3, 0);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(39, 29);
      this.Label6.TabIndex = 16;
      this.Label6.Text = "kg";
      this.Label7.Anchor = AnchorStyles.Left;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.Location = new Point(443, 187);
      this.Label7.Margin = new Padding(3, 3, 3, 0);
      this.Label7.Name = "Label7";
      this.Label7.Size = new Size(25, 29);
      this.Label7.TabIndex = 17;
      this.Label7.Text = "s";
      this.Label8.Anchor = AnchorStyles.Left;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.Location = new Point(443, 227);
      this.Label8.Margin = new Padding(3, 3, 3, 0);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(52, 29);
      this.Label8.TabIndex = 18;
      this.Label8.Text = "m/s";
      this.Label4.Anchor = AnchorStyles.Left;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(93, 227);
      this.Label4.Margin = new Padding(3, 3, 3, 0);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(200, 29);
      this.Label4.TabIndex = 10;
      this.Label4.Text = "Delta V total [m/s]";
      this.exitButton.Anchor = AnchorStyles.None;
      this.exitButton.Location = new Point(7, 108);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new Size(75, 23);
      this.exitButton.TabIndex = 19;
      this.exitButton.Text = "Exit";
      this.exitButton.UseVisualStyleBackColor = true;
      this.ISP.Anchor = AnchorStyles.Left;
      this.ISP.Cursor = Cursors.IBeam;
      this.ISP.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ISP.Location = new Point(318, 185);
      this.ISP.Maximum = new Decimal(new int[4]
      {
        10000,
        0,
        0,
        0
      });
      this.ISP.Name = "ISP";
      this.ISP.Size = new Size(119, 29);
      this.ISP.TabIndex = 23;
      this.Mdry.Anchor = AnchorStyles.Left;
      this.Mdry.Cursor = Cursors.IBeam;
      this.Mdry.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Mdry.Location = new Point(318, 145);
      this.Mdry.Maximum = new Decimal(new int[4]
      {
        999999,
        0,
        0,
        0
      });
      this.Mdry.Name = "Mdry";
      this.Mdry.Size = new Size(119, 29);
      this.Mdry.TabIndex = 24;
      this.Mtot.Anchor = AnchorStyles.Left;
      this.Mtot.Cursor = Cursors.IBeam;
      this.Mtot.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Mtot.Location = new Point(318, 105);
      this.Mtot.Maximum = new Decimal(new int[4]
      {
        999999,
        0,
        0,
        0
      });
      this.Mtot.Name = "Mtot";
      this.Mtot.Size = new Size(119, 29);
      this.Mtot.TabIndex = 25;
      this.resetButton.Anchor = AnchorStyles.None;
      this.resetButton.Location = new Point(7, 148);
      this.resetButton.Name = "resetButton";
      this.resetButton.Size = new Size(75, 23);
      this.resetButton.TabIndex = 27;
      this.resetButton.Text = "Reset";
      this.resetButton.UseVisualStyleBackColor = true;
      this.saveButton.Anchor = AnchorStyles.None;
      this.saveButton.Location = new Point(7, 188);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new Size(75, 23);
      this.saveButton.TabIndex = 28;
      this.saveButton.Text = "Save notes";
      this.saveButton.UseVisualStyleBackColor = true;
      this.loadButton.Anchor = AnchorStyles.None;
      this.loadButton.Location = new Point(7, 228);
      this.loadButton.Name = "loadButton";
      this.loadButton.Size = new Size(75, 23);
      this.loadButton.TabIndex = 29;
      this.loadButton.Text = "Load notes";
      this.loadButton.UseVisualStyleBackColor = true;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.notes, 5);
      this.notes.Dock = DockStyle.Fill;
      this.notes.Location = new Point(3, 263);
      this.notes.Name = "notes";
      this.notes.Size = new Size(789, 359);
      this.notes.TabIndex = 26;
      this.notes.Tag = (object) "";
      this.notes.Text = "notes";
      this.OpenFileDialog1.FileName = "OpenFileDialog1";
      this.OpenFileDialog1.Filter = "Text file|*.txt|All Files|*.*";
      this.SaveFile.DefaultExt = "txt";
      this.SaveFile.Filter = "Text Files | *.txt";
      this.notesResetButton.Anchor = AnchorStyles.Left;
      this.notesResetButton.Location = new Point(503, 148);
      this.notesResetButton.Name = "notesResetButton";
      this.notesResetButton.Size = new Size(142, 23);
      this.notesResetButton.TabIndex = 31;
      this.notesResetButton.Text = "Reset notes";
      this.notesResetButton.UseVisualStyleBackColor = true;
      this.Panel1.BorderStyle = BorderStyle.Fixed3D;
      this.TableLayoutPanel1.SetColumnSpan((Control) this.Panel1, 4);
      this.Panel1.Controls.Add((Control) this.Label9);
      this.Panel1.Dock = DockStyle.Fill;
      this.Panel1.Location = new Point(3, 3);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(494, 94);
      this.Panel1.TabIndex = 32;
      this.Label9.Anchor = AnchorStyles.Left;
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label9.Location = new Point(7, 17);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(386, 55);
      this.Label9.TabIndex = 33;
      this.Label9.Text = "DeltaV calculator";
      this.Label9.TextAlign = ContentAlignment.MiddleCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(795, 625);
      this.Controls.Add((Control) this.TableLayoutPanel1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MinimumSize = new Size(515, 300);
      this.Name = "Form1";
      this.Text = "Delta V calculator for KSP";
      this.TableLayoutPanel1.ResumeLayout(false);
      this.TableLayoutPanel1.PerformLayout();
      this.ISP.EndInit();
      this.Mdry.EndInit();
      this.Mtot.EndInit();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
