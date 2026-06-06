using System.Text;
using UglyToad.PdfPig;
using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;

using Xceed.Words.NET;
using Xceed.Document.NET;
using System.Collections.Generic;
using exambank.data.Models;

namespace exambank.logic.Service
{
    public class DocumentService
    {
        // Hàm mới để xuất từ đề thi ra Word (DocX)
        public void ExportToWord(string saveFilePath, ExamModel exam, List<QuestionModel> questions)
        {
            using (DocX document = DocX.Create(saveFilePath))
            {
                // Thêm tiêu đề
                var titleFormat = new Formatting()
                {
                    FontFamily = new Xceed.Document.NET.Font("Times New Roman"),
                    Size = 16,
                    Bold = true
                };

                document.InsertParagraph($"KỲ THI/ KIỂM TRA", false, titleFormat)
                        .Alignment = Alignment.center;

                var infoFormat = new Formatting() { FontFamily = new Xceed.Document.NET.Font("Times New Roman"), Size = 13, Bold = true };
                document.InsertParagraph($"Môn: {exam.Subject} - Thời gian: {exam.Duration} phút - Mã đề: {exam.ExamCode}", false, infoFormat)
                        .Alignment = Alignment.center;

                document.InsertParagraph().AppendLine();

                // Thêm nội dung câu hỏi
                var textFormat = new Formatting() { FontFamily = new Xceed.Document.NET.Font("Times New Roman"), Size = 12 };
                var boldFormat = new Formatting() { FontFamily = new Xceed.Document.NET.Font("Times New Roman"), Size = 12, Bold = true };

                int qNumber = 1;
                foreach (var q in questions)
                {
                    var p = document.InsertParagraph();
                    p.Append($"Câu {qNumber++}: ", boldFormat);
                    p.Append($"{q.Question}", textFormat);

                    var pOptions = document.InsertParagraph();
                    pOptions.Append($"A. {q.OptionA}", textFormat).AppendLine();
                    pOptions.Append($"B. {q.OptionB}", textFormat).AppendLine();
                    pOptions.Append($"C. {q.OptionC}", textFormat).AppendLine();
                    pOptions.Append($"D. {q.OptionD}", textFormat).AppendLine();

                    document.InsertParagraph().AppendLine();
                }

                // Lưu lại
                document.Save();
            }
        }

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