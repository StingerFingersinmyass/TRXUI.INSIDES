using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;

namespace TRX
{
	// Token: 0x02000005 RID: 5
	public static class Extensions
	{
		// Token: 0x06000020 RID: 32 RVA: 0x0000377C File Offset: 0x0000197C
		public static global::ICSharpCode.AvalonEdit.Highlighting.IHighlightingDefinition LoadFromResource(this global::ICSharpCode.AvalonEdit.Highlighting.HighlightingManager m, string resourceName)
		{
			global::System.Reflection.Assembly executingAssembly = global::System.Reflection.Assembly.GetExecutingAssembly();
			string text = executingAssembly.GetManifestResourceNames().Single((string str) => str.EndsWith(resourceName));
			global::ICSharpCode.AvalonEdit.Highlighting.IHighlightingDefinition highlightingDefinition2;
			using (global::System.IO.Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text))
			{
				using (global::System.Xml.XmlTextReader xmlTextReader = new global::System.Xml.XmlTextReader(manifestResourceStream))
				{
					global::ICSharpCode.AvalonEdit.Highlighting.IHighlightingDefinition highlightingDefinition = global::ICSharpCode.AvalonEdit.Highlighting.Xshd.HighlightingLoader.Load(xmlTextReader, m);
					m.RegisterHighlighting(highlightingDefinition.Name, new string[0], highlightingDefinition);
					highlightingDefinition2 = highlightingDefinition;
				}
			}
			return highlightingDefinition2;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020F7 File Offset: 0x000002F7
		public static T GetTemplateChild<T>(this global::System.Windows.Controls.Control e, string name) where T : global::System.Windows.FrameworkElement
		{
			return e.Template.FindName(name, e) as T;
		}
	}
}
