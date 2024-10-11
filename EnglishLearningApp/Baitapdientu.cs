using System.Collections.Generic;

namespace EnglishLearningApp
{
    public class BaiTapDienTu
    {
        public string Debai { get; set; } // The exercise text with blanks
        public string Dapan { get; set; } // The full answer text without blanks
        public List<string> Dapantungcau { get; set; } // List of correct answers for each blank
    }
}
