using System;
using Xamarin.Forms;

namespace EditorPlaceholderEffectSample.Controls
{
	public class EditorWithPlaceholder : Editor
	{
		public EditorWithPlaceholder()
		{
			Effects.Add(Effect.Resolve("Xamarin.PlaceholderEditorEffect"));
		}

		public string Placeholder { get; set; }
		public Color PlaceholderTextColor { get; set; } = Color.LightGray;
	}
}
