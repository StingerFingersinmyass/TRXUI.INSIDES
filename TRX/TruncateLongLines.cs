using System;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Rendering;

namespace TRX
{
	// Token: 0x0200000D RID: 13
	public class TruncateLongLines : global::ICSharpCode.AvalonEdit.Rendering.VisualLineElementGenerator
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000046B8 File Offset: 0x000028B8
		public override int GetFirstInterestedOffset(int startOffset)
		{
			global::ICSharpCode.AvalonEdit.Document.DocumentLine lastDocumentLine = base.CurrentContext.VisualLine.LastDocumentLine;
			if (lastDocumentLine.Length > 400)
			{
				int num = lastDocumentLine.Offset + 400 - "-- ...".Length;
				if (startOffset <= num)
				{
					return num;
				}
			}
			return -1;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002242 File Offset: 0x00000442
		public override global::ICSharpCode.AvalonEdit.Rendering.VisualLineElement ConstructElement(int offset)
		{
			return new global::ICSharpCode.AvalonEdit.Rendering.FormattedTextElement("-- ...", base.CurrentContext.VisualLine.LastDocumentLine.EndOffset - offset);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002265 File Offset: 0x00000465
		public TruncateLongLines()
		{
		}

		// Token: 0x04000049 RID: 73
		private const int maxLength = 400;

		// Token: 0x0400004A RID: 74
		private const string ellipsis = "-- ...";

		// Token: 0x0400004B RID: 75
		private const int charactersAfterEllipsis = 0;
	}
}
