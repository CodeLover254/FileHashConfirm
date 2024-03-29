﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileHashConfirm
{
    public partial class AppForm : Form
    {
        //Class Attributes
        private const int Md5Length = 32;
        private const int Sha1Length = 40;
        private const int Sha256Length = 64;
        private readonly Color _successColor = Color.FromArgb(192, 255, 192);
        private readonly Color _errorColor = Color.FromArgb(255, 192, 192);
        private string[] _hashes = new string[] { "", "", "" };
        private PictureBox[] _pictureBoxes; 
        private TextBox[] _textBoxes; 

        //Constructor
        public AppForm()
        {
            InitializeComponent();
            this._pictureBoxes = new PictureBox[] { statusIconMD5, statusIconSHA1, statusIconSHA256 };
            this._textBoxes = new TextBox[] { md5HashTextBox, sha1HashTextBox, sha256HashTextBox };
        }

        /// <summary>
        /// A handler for the Drag Drop Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnFileDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length == 1)
            {
                _hashes = await HashingMachine.GetFileChecksumAsync(files[0]);
                ProcessHashes();
                dropZoneLabel.Text = "Drag and Drop File Here";
            }
            else
            {
                ShowError("Only one file at a time.");
            }
        }

        /// <summary>
        /// A handler for the Drag Enter event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFileDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Reset(true);
                e.Effect = DragDropEffects.Copy;
                dropZoneLabel.Text = "Great! Now drop it.";
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// A handler for the Drag Leave Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFileDragLeave(object sender, EventArgs e)
        {
            dropZoneLabel.Text = "Drag and Drop File Here";
        }

        /// <summary>
        /// A method that displays a message box with an error when required
        /// </summary>
        /// <param name="message"></param>
        private static void ShowError(string message)
        {
            MessageBox.Show(null, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// A handler for the Text Change Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnUserInput(object sender, EventArgs e)
        {
            if (CheckForHashes()) {
                Reset(false);
                MakeComparisons();
            }
        }

        /// <summary>
        /// A method that ensures that none of the indicated
        /// text boxes are empty
        /// </summary>
        /// <returns></returns>
        private bool CheckForHashes()
        {
            return md5HashTextBox.Text != "" && sha1HashTextBox.Text != "" && sha256HashTextBox.Text != "";
        }

        /// <summary>
        /// A method to display the hashes and later
        /// call a method to compare with the user input
        /// </summary>
        private void ProcessHashes()
        {
            md5HashTextBox.Text = _hashes[0];
            sha1HashTextBox.Text = _hashes[1];
            sha256HashTextBox.Text = _hashes[2];
            MakeComparisons();
        }

        /// <summary>
        /// A method to compare a specific hash to a user input
        /// </summary>
        private void MakeComparisons()
        {
            string inputHash = givenHashTextBox.Text;
            if (inputHash != "")
            {
                if (inputHash.Length == Md5Length)
                {
                    CompareHashes(inputHash, _hashes[0], md5HashTextBox, statusIconMD5);
                }
                else if (inputHash.Length == Sha1Length)
                {
                    CompareHashes(inputHash, _hashes[1], sha1HashTextBox, statusIconSHA1);
                }
                else if (inputHash.Length == Sha256Length)
                {
                    CompareHashes(inputHash, _hashes[2], sha256HashTextBox, statusIconSHA256);
                }
                else
                {
                    NoMatchState();
                }
            }
        }

        /// <summary>
        /// A method to compare user input to a given hash
        /// and give the appropriate feedback
        /// </summary>
        /// <param name="input"></param>
        /// <param name="hash"></param>
        /// <param name="textbox"></param>
        /// <param name="picturebox"></param>
        private void CompareHashes(string input, string hash, TextBox textbox, PictureBox picturebox)
        {
            if (input.ToLower().Equals(hash.ToLower()))
            {
                SetStatusDisplay(textbox, picturebox, true);
            }
            else
            {
                SetStatusDisplay(textbox, picturebox, false);
            }
        }

        /// <summary>
        /// A method responsible to manipulation of the control style
        /// and state of image display
        /// </summary>
        /// <param name="textbox"></param>
        /// <param name="picturebox"></param>
        /// <param name="success"></param>
        private void SetStatusDisplay(TextBox textbox, PictureBox picturebox, bool success)
        {
            if (success)
            {
                textbox.BackColor = _successColor;
                picturebox.Image = Properties.Resources.tick;
            }
            else
            {
                textbox.BackColor = _errorColor;
                picturebox.Image = Properties.Resources.cancel;
            }
        }

        /// <summary>
        /// A method to reset the textfields by either clearing
        /// or changing their styles.The method also removes
        /// displayed images from the UI.
        /// </summary>
        /// <param name="clearTextBoxes"></param>
        private void Reset(bool clearTextBoxes)
        {
            foreach (var pictureBox in _pictureBoxes)
            {
                pictureBox.Image = null;
            }

            foreach (var textBox in _textBoxes)
            {
                if (clearTextBoxes)
                {
                    textBox.Clear();
                }
                textBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// A method that sets the appropriate colors and images
        /// if the input doesnt match any calculated hash.
        /// </summary>
        private void NoMatchState()
        {
            for(int i = 0; i < _pictureBoxes.Length; i++)
            {
                SetStatusDisplay(_textBoxes[i], _pictureBoxes[i], false);
            }
        }

    }
}
