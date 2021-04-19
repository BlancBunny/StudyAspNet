using DotNetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNote.Board
{
    public partial class BoardView : System.Web.UI.Page
    {
        private string _Id;

        protected void Page_Load(object sender, EventArgs e)
        {
            lnkDelete.NavigateUrl = $"BoardDelete.aspx?Id={Request["Id"]}";
            lnkModify.NavigateUrl = $"BoardDelete.aspx?Id={Request["Id"]}";
            lnkReply.NavigateUrl = $"BoardDelete.aspx?Id={Request["Id"]}";

            _Id = Request["Id"];
            if (string.IsNullOrEmpty(_Id)) Response.Redirect("BoardList.aspx");

            if (!Page.IsPostBack) DisplayData();
        }

        private void DisplayData()
        {
            var note = (new NoteRepository()).GetNoteById(Convert.ToInt32(_Id));

            lblNum.Text = _Id;
            lblName.Text = note.Name;
            lblEmail.Text = string.Format($"<a href=\"mailto:{note.Email}\">{note.Email}</a>");
            lblTitle.Text = note.Title;
            string content = note.Content;

            string strEncoding = note.Encoding;
            if (strEncoding == "Text") // Text : 소스 그대로 
            {
                lblContent.Text = Helper.HtmlUtility.EncodeWithTabAndSpace(content);
            }
            else if (strEncoding == "Mixed") // 엔터만 처리
            {
                lblContent.Text = content.Replace("\r\n", "<br />");
            }
            else // HTML : HTML 형식으로 출력 
            {
                lblContent.Text = content;
            }

            lblReadCount.Text = note.ReadCount.ToString();
            lblHomepage.Text = string.Format(
                $"<a href='{note.Homepage}' target='_blank'>{note.Homepage}</a>");
            lblPostDate.Text = note.PostDate.ToString();
            lblPostIP.Text = note.PostIp;
            if (note.FileName.Length > 1)
            {
                lblFile.Text = String.Format(
                    $"<a href='./BoardDown.aspx?Id={note.Id}'>"
                  + $"{"<img src=\"/images/ext/ext_zip.gif\" border=\"0\">"}" 
                  + $"{note.FileName} / 다운로드 횟수: {note.DownCount}</a>");
                    
                if (Helper.BoardLibrary.IsPhoto(note.FileName))
                {
                    ltrImage.Text = "<img src=\'ImageDown.aspx?FileName="
                        + $"{Server.UrlEncode(note.FileName)}\'>";
                }
            }
            else
            {
                lblFile.Text = "(업로드된 파일이 없습니다.)";
            }
        }
    }
}