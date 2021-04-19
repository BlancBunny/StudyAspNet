using DotNetNote.Controls;
using DotNetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNote.Board
{
    public partial class BoardList : System.Web.UI.Page
    {
        private NoteRepository _repo;
        public bool SearchMode { get; set; } = false; // 검색 모드이면 true, 아니면 false
        public string SearchField { get; set; }  
        public string SearchQuery { get; set; }

        public int RecordCount = 0;

        public int PageIndex = 0;
        public BoardList()
        {
            _repo = new NoteRepository(); // SQLConnection 생성
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SearchMode = !string.IsNullOrEmpty(Request.QueryString["SearchField"]) &&
                !string.IsNullOrEmpty(Request.QueryString["SearchQuery"]);
            if (SearchMode)
            {
                SearchField = Request.QueryString["SearchField"];
                SearchQuery = Request.QueryString["SearchQuery"];
            }
            if (Request["Page"] != null)
            {
                PageIndex = Convert.ToInt32(Request["Page"]) - 1;
            }
            else PageIndex = 0; // 1페이지

            // TODO: 쿠키 사용해서 리스트 페이지번호 유지 
            if (Request.Cookies["DotNetNote"] != null)
            {
                if (!string.IsNullOrEmpty(Request.Cookies["DotNetNote"]["PageNum"]))
                {
                    PageIndex = Convert.ToInt32(Request.Cookies["DotNetNote"]["PageNum"]);
                }
                else PageIndex = 0;
            }


            if (!SearchMode)
            {
                RecordCount = _repo.GetCountAll();
            }
            else
            {
                RecordCount = _repo.GetCountBySearch(SearchField, SearchQuery);
            }
            lblTotalRecord.Text = "Total Record : " + RecordCount;



            



            // 페이징 처리 
            PagingControl.PageIndex = PageIndex;
            PagingControl.RecordCount = RecordCount;

            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }
        private void DisplayData()
        {
            if (!SearchMode)
            {
                grvNotes.DataSource = _repo.GetAll(PageIndex);
            }
            else // 검색 결과 리스트
            {
                grvNotes.DataSource = _repo.GetSeachAll(PageIndex, SearchField, SearchQuery);
            }
            grvNotes.DataBind();
        }
    }
}