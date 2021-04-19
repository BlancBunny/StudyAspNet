namespace DotNetNote.Models
{
    public enum BoardWriteFormType
    {
        Write,      // 쓰기 모드
        Modify,     // 수정 모드
        Reply       // 댓글 모드
    }

    public enum ContentEncodingType
    {
        Text,       // 일반텍스트
        Html,       // HTML입력모드
        Mixed       // HTML + 엔터키모드 
    }
}