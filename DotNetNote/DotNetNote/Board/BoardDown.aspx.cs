﻿using DotNetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNote.Board
{
    public partial class BoardDown : System.Web.UI.Page
    {
        private string fileName = "";
        private string dir = "";

        private NoteRepository _repository;
        public BoardDown()
        {
            _repository = new NoteRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // 넘겨져 온 번호에 해당하는 파일명 가져오기(보안때문에... 파일명 숨김)
            fileName =
                _repository.GetFileNameById(Convert.ToInt32(Request["Id"]));

            // 다운로드 폴더 지정 : 실제 사용시 반드시 변경
            dir = Server.MapPath("../Files/");
            if (fileName == null) // 특정 번호에 해당하는 첨부파일이 없다면,
            {
                Response.Clear();
                Response.End();
            }
            else
            {
                // 다운로드 카운트 증가 메서드 호출
                _repository.UpdateDownCount(fileName);

                //[!] 강제 다운로드 창 띄우기 주요 로직
                Response.Clear();
                Response.ContentType = "application/octet-stream";
                Response.AddHeader("Content-Disposition", "attachment;filename="
                    + Server.UrlPathEncode(
                        (fileName.Length > 50) ?
                            fileName.Substring(fileName.Length - 50, 50) :
                                fileName));
                Response.WriteFile(dir + fileName);
                Response.End();
            }
        }
    }
}