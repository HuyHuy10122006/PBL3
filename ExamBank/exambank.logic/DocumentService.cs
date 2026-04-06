using System.Text;
using UglyToad.PdfPig;
using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;

namespace exambank.logic
{
    public class DocumentService
    {
        // 1. Đọc Text từ PDF
        public string ExtractTextFromPdf(string filePath)
        {
            StringBuilder text = new StringBuilder();
            using (PdfDocument document = PdfDocument.Open(filePath))
            {
                foreach (var page in document.GetPages())
                {
                    text.AppendLine(ContentOrderTextExtractor.GetText(page));
                }
            }
            return text.ToString();
        }

        // 2. Cắt nhỏ văn bản (Chunking)
        public List<string> ChunkText(string fullText, int chunkSize = 2000)
        {
            List<string> chunks = new List<string>();
            // Cắt đơn giản theo độ dài (Thực tế bạn có thể cắt theo dấu chấm câu hoặc đoạn văn để logic hơn)
            for (int i = 0; i < fullText.Length; i += chunkSize)
            {
                if (i + chunkSize > fullText.Length) chunkSize = fullText.Length - i;
                chunks.Add(fullText.Substring(i, chunkSize));
            }
            return chunks;
        }
    }
}