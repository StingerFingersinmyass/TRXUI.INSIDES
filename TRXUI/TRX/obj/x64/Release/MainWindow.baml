   M S B A M L   `   `   `  ���� D  @FluentWPF, Version=0.9.0.1, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF  > :TRX, Version=1.9.7.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TRXTRX b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes    TRX.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Efw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     #localclr-namespace:TRX     :wpfanimated"http://wpfanimatedgif.codeplex.com     ^ThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     -   )   #SourceChord.FluentWPF.AcrylicWindow   Name$  window�� J� Opacity$ 1Q�*   $SourceChord.FluentWPF.PointerTracker   Enabled .    NoiseOpacity$ 0Q� � Title$ 
TRX v1.9.7��$	��340��$	��695�� � 
ResizeMode$ CanResizeWithGrip=�   AcrylicWindowStyle$ NoIcon=�   Enabled . ���	#7F000000$	��700��$	��350�� � WindowStartupLocation$ CenterScreen=�	 � 	Resources	    Menu.Static.Background
 �� Color  
MenuStyle1 �� 
TargetType �� Property �� Value �� 
TargetType �� Padding J� SnapsToDevicePixels  MenuItemControlTemplate2 ��Name � ColumnDefinitions ��Name m� Icon F�Name �� HeaderStringFormat �� ContentStringFormat �Name � AllowsTransparency �� RelativeSource ��Name �� 
ResourceId �� TypeInTargetAssembly �� ClearTypeHint ��Name  �� ElementName! ��Name-  'System.Windows.Input.KeyboardNavigation"   DirectionalNavigation# � IsSharedSizeScope$   TabNavigation% �� Triggers& P� Property' P� Value( �� 
TargetName) P� 
SourceName  ListBoxStyle2  MaterialDesignBody* �� CornerRadius+ ]� 
Conditions, �� Property- �� Value  FocusVisual. �� StrokeDashArray  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background 	 Button.MouseOver.Border 
 Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonStyle1  ComboBox.Static.Background/ �� EndPoint0 �� 
StartPoint1 � Color2 � Offset  ComboBox.Static.Border ' #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background * &ComboBox.Static.Editable.Button.Border  ComboBox.MouseOver.Glyph ! ComboBox.MouseOver.Background  ComboBox.MouseOver.Border * &ComboBox.MouseOver.Editable.Background & "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Glyph  ComboBox.Pressed.Background  ComboBox.Pressed.Border (  $ComboBox.Pressed.Editable.Background $!  ComboBox.Pressed.Editable.Border /" +ComboBox.Pressed.Editable.Button.Background +# 'ComboBox.Pressed.Editable.Button.Border $ ComboBox.Disabled.Glyph  % ComboBox.Disabled.Background & ComboBox.Disabled.Border )' %ComboBox.Disabled.Editable.Background %( !ComboBox.Disabled.Editable.Border 0) ,ComboBox.Disabled.Editable.Button.Background ,* (ComboBox.Disabled.Editable.Button.Border + ComboBox.Static.Glyph , ComboBoxToggleButton3 ^� 
Conditions4 �� Binding5 �� AncestorType - ComboBoxTemplate6 �Name7 �� Mode5  /Microsoft.Windows.Themes.SystemDropShadowChrome8  Name9   Color: �� MaxDropDownHeight; ��Name< d�Name . ToggleButtonStyle4= d� 	IsChecked> �� SelectionBoxItemTemplate? �� SelectionBoxItem#@ �� SelectionBoxItemStringFormatA J� IsHitTestVisible / TextBox.Static.Background 0 ComboBoxEditableTextBox 1 ComboBoxEditableTemplateB ��NameC �� 
IsReadOnly 2 ToggleButtonStyle3 3 ComboBoxStyle4D �� Triggers 4 ButtonStyle2 !5 MenuItem.Highlight.Background 6 MenuItem.Highlight.Border 7 Menu.Disabled.Foreground *8 &MenuItem.Highlight.Disabled.Background &9 "MenuItem.Highlight.Disabled.Border : MenuItem.Selected.Border  ; MenuItem.Selected.Background < 	Checkmark = Menu.Static.ForegroundE z� SharedSizeGroupF ��NameG m� InputGestureText > Menu.Static.Border ? Menu.Static.Separator @ UpArrow A MenuScrollButtonH �� BasedOn $B  MenuScrollingVisibilityConverter C 	DownArrowI � RowDefinitionsJ �� CanContentScrollK �� LineUpCommandL `� ConverterParameterM �� FallbackValueN `� 	ConverterO �� PathP �� LineDownCommandQ � PlacementTarget D 
RightArrowR � HorizontalOffsetS � VerticalOffset E MenuItemStyle1�� %�f  &	        &	      7   &	 �     &	 6    &	 9
    &	 �
    &	 �
    &	 �
    &		 �
    &	
 �
    &	 �
    &	     &	     &	 /    &	 D    7  7  7  &	 y    &	 �    &	 �    &	 �    &	     &	 '    &	 <    &	 Q    &	 �    &	 �    &	 �    &	 �    &	 D    &	 Y    &	 n    &	 �    &	  �    &	! �    &	"     &	# a    &	$ v    &	% �    &	& �    &	' �    &	( �    &	) �    &	* �    &	+ 	    &	,     7  7  7 + 7  7  7  7  7  7  7  7  7  7  7  7  7  7  7   7 ! 7 " 7 # 7 $ 7 % 7 & 7 ' 7 ( 7 ) 7 * &	- V    &	/ !    &	0 +!    &	1 �"    7 , 7 / 7 0 &	2 )    7  7 + 7  7  7  7  7  7  7  7  7  7   7 ! 7 " 7 # 7 $ 7 % 7 & 7 ' 7 ( 7 ) 7 * &	3 �2    7  7  7  7 - 7 1 &	. 4    7  7 + 7  7  7  7  7  7  7  7  7   7 ! 7 " 7 # 7 $ 7 % 7 & 7 ' 7 ( 7 ) 7 * &	4 �=    7  7  7  7  7 
 7  7  7  &	5 �@    &	6 �@    &	7 �@    &	8 �@    &	9 �@    &	: �@    &	; A    &	< 'A    &	= �A    (�� �A    $ SubmenuItemTemplateKey��" m�)7 : 7 ; 7 < 7 5 7 6 7 7 7 7 7 8 7 9 &	> lF    &	? �F    &	@ �F    &	A �F    &	B G    &	C �G    (�� �G    $ MenuScrollViewer��" �)7 A 7 B 7 @ 7 = 7 A 7 B 7 C 7 = (�� �K    $ TopLevelHeaderTemplateKey��" m�)7 < 7 > 7   7 ? 7 5 7 6 7 7 7 7 (�� R    $ TopLevelItemTemplateKey��" m�)7 < 7 = 7 5 7 6 7 7 7 7 7 8 7 9 &	D �U    (�� �U    $ SubmenuHeaderTemplateKey��" m�)7 6 7 5 7 = 7 D 7 = 7 > 7   7 6 7 7 7 7 7 7 &	E �]    7 = 7   7 > 7 = �� $
 	#FFF0F0F0���� " o�.���  � ��8   ��  � ��# � ����  � ��# � ����  � ��# � ����  � ��# � ����  � ��# � ����  � ��$ Center=���  � �� �� " o�.R��� $��0q�# z�� . ._��� # z �� " m�.R��� $ templateRoot��#��z��#��z��#��z�� . ._�� $��Center=� �� $
��Auto ��� $
��Auto �.+��� $
 Icon��#��z $
��Icon��$��Center=�$��16��$��3q�# z $��Center=�$��16��F� $ 
GlyphPanel��T������� �O �`�G �ڊ � �D �ڊ �    �XO � � �g5 ���A  ] ������� @    р�� �O #��z��$��LeftToRight=�$��3q�$y�	Collapsed=�$��Center=��� #��z��#��z��$��1��# z $��Header��#��z����. # z � $ 
PART_Popup�� . |�.  #��� -�$��Bottom=����� *IsSubmenuOpen+ �� *TemplatedParent+.���� $ SubMenuBorder��$��1q����	#66000000$ 2q���Z� ._��� $ SubMenuScrollViewer�����	#FFFFFFFF���	#19000000��C� *�� $ MenuScrollViewer��" �+.��� $ Enabled=�.+��� $
��Left=�$��0��$	��Top=�$��0��.+��� $ 
OpaqueRect������ *
Background+$  SubMenuBorder������ *ActualHeight+$  SubMenuBorder������ *ActualWidth+$  SubMenuBorder���� $
��Left=�$��29,2,0,2q�$��1����Z� �� $! ItemsPresenter��$" Cycle=�# . # z $$ Cycle=�% P� "& �@m�IsSuspendingPopupAnimation' . . ��� $( 
PART_Popup�� � ��$
 None=�P� ' Z� & �@m�Icon. ��� $
( Icon�� � y�$ 	Collapsed=�P� & �@m�	IsChecked' . . ��� $( 
GlyphPanel�� � y�$ Visible=��� $
( Icon�� � y�$ 	Collapsed=�P� & �@m�IsHighlighted' . . ��� $( templateRoot�� � �� �	#3D26A0DA�� $( templateRoot�� � �� �	#FF26A0DAP� & � {�' .  . ��� $( templateRoot�� � �� �	#FF707070�� $( 
GlyphPanel�� � �� �	#FF707070P� $) SubMenuScrollViewer��& � ��' .  . ��� $( 
OpaqueRect�� �� *VerticalOffset+$  SubMenuScrollViewer�� �@��Top�� $( 
OpaqueRect�� �� *HorizontalOffset+$  SubMenuScrollViewer�� �@��Left�� " ��.���  � �� �	#00FFFFFF��  � �� �	#00FFFFFF��  � ��$ 0q���  � ��# �  ��  � ��$ Disabled=���  � ��$
 Auto=���  � �� . ��  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled .  ��  � ��$ Center=���  � �� �� " ��.R��� $ Bd��$* 0��#��z��#��z��#��z�� . ._��� |�.  #��z��.���� # z % ]� + �� , �@��
IsGrouping- . �� ", �@%�IsVirtualizingWhenGrouping- .  ./���  � �� .  �� .���  � �� �� .R��� $��2q� . #��� ��$��1��$	. 1 2R��� $
 	#FFDDDDDD���� $
 	#FF707070���� $
 	#FFBEE6FD���� $
 	#FF3C7FB1���� $
 	#FFC4E5F6���� $
 	#FF2C628B���� $
 	#FFF4F4F4���� $
 	#FFADB2B5���� $
 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��#��z��#��z��#��z�� . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z��% P� & �@��IsDefaulted' . . ��� $( border�� � �� �	#00DDDDDDP� & �@J�IsMouseOver' . . ��� $( border�� � �� �	#00DDDDDD�� $( border�� � �� �	#00DDDDDDP� & � ��' . . ��� $( border�� � �� �	#00DDDDDD�� $( border�� � �� �	#00DDDDDDP� & � {�' .  . ��� $( border�� � �� �	#00DDDDDD�� $( border�� � �� �	#00DDDDDD�� $( contentPresenter�� � �� �	#00DDDDDD�� $	/ 0,1&�$	0 0,0&�.��� $1 	#FFF0F0F0��$	2 0.0Q�� $1 	#FFE5E5E5��$	2 1.0Q��� $
 	#FFACACAC���� $
 	#FFFFFFFF���� $
 	#FFABADB3���� $
 	#19000000���� $
 	#19000000���� $
 	#FF000000���� $	/ 0,1&�$	0 0,0&�.��� $1 	#FFECF4FC��$	2 0.0Q�� $1 	#FFDCECFC��$	2 1.0Q��� $
 	#FF7EB4EA���� $
 	#FFFFFFFF���� $
 	#FF7EB4EA���� $	/ 0,1&�$	0 0,0&�.��� $1 	#FFEBF4FC��$	2 0.0Q�� $1 	#FFDCECFC��$	2 1.0Q��� $
 	#FF7EB4EA���� $
 	#FF000000���� $	/ 0,1&�$	0 0,0&�.��� $1 	#FFDAECFC��$	2 0.0Q�� $1 	#FFC4E0FC��$	2 1.0Q��� $
 	#FF569DE5���� $
 	#FFFFFFFF���� $
 	#FF569DE5���� $	/ 0,1&�$	0 0,0&�.��� $1 	#FFDAEBFC��$	2 0.0Q�� $1 	#FFC4E0FC��$	2 1.0Q��� $
 	#FF569DE5���� $
 	#FFBFBFBF���� $
 	#FFF0F0F0���� $
 	#FFD9D9D9���� $
 	#FFFFFFFF���� $
 	#FFBFBFBF���� $
 	#19000000���� $
 	#19000000���� $
 	#FF606060���� " d�.���  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  �@��	ClickMode$ Press=���  � �� �� " d�.R��� $ templateRoot�� . #��z��8��  8�� ._��� $ splitBorder��#��� r� . $��0q�$��Right=�$��1q����	#00FFFFFF._�F� $ arrow��$��Center=�$��0q�$��Center=�F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� % ^� 3 �� 4 �� *
IsEditable+ �� "5 ��- true�� 4 �� *IsMouseOver+ �� *Self+	- false�� 4 �� *	IsPressed+ �� *Self+	- false�� 4 �� *	IsEnabled+ �� *Self+- true.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ���� $( splitBorder��8   � ���� $( splitBorder��8   � ��P� & �@J�IsMouseOver' . . ��� $( arrow��8   � ��^� 3 �� 4 �� *IsMouseOver+ �� *Self+- true�� 4 �� *
IsEditable+ �� "5 ��	- false.0��� $( templateRoot��8   � ���� $( templateRoot��8 	  � ��^� 3 �� 4 �� *IsMouseOver+ �� *Self+- true�� 4 �� *
IsEditable+ �� "5 ��- true.0��� $( templateRoot��8 
  � ���� $( templateRoot��8   � ���� $( splitBorder��8   � ���� $( splitBorder��8   � ��P� & � ��' . . ��� $( arrow��8   � ��^� 3 �� 4 �� *	IsPressed+ �� *Self+- true�� 4 �� *
IsEditable+ �� "5 ��	- false.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ��^� 3 �� 4 �� *	IsPressed+ �� *Self+- true�� 4 �� *
IsEditable+ �� "5 ��- true.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ���� $( splitBorder��8   � ���� $( splitBorder��8   � ��P� & � {�' .  . ��� $( arrow��8   � ��^� 3 �� 4 �� *	IsEnabled+ �� *Self+	- false�� 4 �� *
IsEditable+ �� "5 ��	- false.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ��^� 3 �� 4 �� *	IsEnabled+ �� *Self+	- false�� 4 �� *
IsEditable+ �� "5 ��- true.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ���� $( splitBorder��8   � ���� $( splitBorder��8   � ���� " ��.R�� $6 templateRoot�� .  �� $��* ��� #��� r�$��0 �.+�� $ 
PART_Popup�� . $��2��$��1q�#��� .�$��Bottom=����� *IsDropDownOpen+$7 TwoWay=� �� *TemplatedParent+.��  $8 shadow��$9 Transparent��#��z: ���� *ActualWidth+$  templateRoot��._��� $ dropDownBorder��$��1q���Z� ��Z� ._��� $ DropDownScrollViewer��.��� $
6 grid��$ Enabled=�.+��� $; canvas��$
��Left=�$��0��$	��Top=�$��0��.+��� $ 
opaqueRect������ *
Background+$  dropDownBorder������ *ActualHeight+$  dropDownBorder������ *ActualWidth+$  dropDownBorder���� $! ItemsPresenter��$" 	Contained=�# z d� $< toggleButton��$��0q�$��2��#��� . = �� *IsDropDownOpen+$7 TwoWay=� �� *TemplatedParent+�� $ contentPresenter��#��z> #��z��#��z? # z@ #��z��A .  #��z��# z #��z��% P� $) 
PART_Popup��& �@�HasDropShadow' . . ��� $( shadow�� � ��$ 0,0,5,5q��� $( shadow�� �@ Color$ 	#71000000��P� & �@��HasItems' .  . ��� $( dropDownBorder�� � ��$ 95��]� + �� , �@��
IsGrouping- . �� ", �@%�IsVirtualizingWhenGrouping- .  ./���  � �� .  P� $) DropDownScrollViewer��& � ��' .  . ��� $( 
opaqueRect�� �� *VerticalOffset+$  DropDownScrollViewer�� �@��Top�� $( 
opaqueRect�� �� *HorizontalOffset+$  DropDownScrollViewer�� �@��Left�� $
 	#FFFFFFFF���� " ��.���  �@�OverridesDefaultStyle . ��  �@J�	AllowDrop . ��  � ��$ 0����  � ��$ 0����  �@�FocusVisualStyle Z� ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ PART_ContentHost�����	#19000000|�.  $��Hidden=�$��Hidden=��� " ��.R�� $6 templateRoot�� .  �� $��* ��� #��� r�$��0 �.+�� $ 
PART_Popup�� . $��2��#��� .�$��Bottom=����� *IsDropDownOpen+ �� *TemplatedParent+.��  $8 shadow��$9 	#19000000��#��z: ���� *ActualWidth+$  templateRoot��._��� $ dropDownBorder��#��� ��$��1q�#��� ��._��� $ DropDownScrollViewer��.��� $
6 grid��$ Enabled=�.+��� $; canvas��$
��Left=�$��0��$	��Top=�$��0��.+��� $ 
opaqueRect������ *
Background+$  dropDownBorder������ *ActualHeight+$  dropDownBorder������ *ActualWidth+$  dropDownBorder���� $! ItemsPresenter��$" 	Contained=�# z d� $< toggleButton��#��z��#��z��#��z��$��2��8��  = �� *IsDropDownOpen+$7 TwoWay=� �� *TemplatedParent+�� $ border��#��z��8�� ._��� $B PART_EditableTextBox��#��z��#��z��#��z��8�� C �� *
IsReadOnly+ �� *TemplatedParent+% P� & � {�' .  . ��� $( border�� �@J�Opacity$
 0.56Q�P� & �@J�IsKeyboardFocusWithin' . . ���  � �� �	#FF000000P� $) 
PART_Popup��& �@�HasDropShadow' . . ��� $( shadow�� � ��$ 0,0,5,5q��� $( shadow�� �@ Color$ 	#71000000��P� & �@��HasItems' .  . ��� $( dropDownBorder�� � ��$ 95��]� + �� , �@��
IsGrouping- . �� ", �@%�IsVirtualizingWhenGrouping- .  ./���  � �� .  P� $) DropDownScrollViewer��& � ��' .  . ��� $( 
opaqueRect�� �� *VerticalOffset+$  DropDownScrollViewer�� �@��Top�� $( 
opaqueRect�� �� *HorizontalOffset+$  DropDownScrollViewer�� �@��Left�� " d�.���  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  �@��	ClickMode$ Press=���  � �� �� " d�.R��� $ templateRoot�� . #��z��8��  ._��� $ splitBorder��#��� r� . $��0q�$��Right=�$��1q����	#00FFFFFF���	#02000000._�F� $ arrow��$��Center=�$��0q�$��Center=�F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� % ^� 3 �� 4 �� *
IsEditable+ �� "5 ��- true�� 4 �� *IsMouseOver+ �� *Self+	- false�� 4 �� *	IsPressed+ �� *Self+	- false�� 4 �� *	IsEnabled+ �� *Self+- true.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ���� $( splitBorder��8   � ���� $( splitBorder��8   � ��P� & �@J�IsMouseOver' . . ��� $( arrow��8   � ��^� 3 �� 4 �� *IsMouseOver+ �� *Self+- true�� 4 �� *
IsEditable+ �� "5 ��	- false.0��� $( templateRoot�� � �� �	#19000000�� $( templateRoot�� � �� �	#19000000^� 3 �� 4 �� *IsMouseOver+ �� *Self+- true�� 4 �� *
IsEditable+ �� "5 ��- true.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ���� $( splitBorder��8 	  � ���� $( splitBorder��8 
  � ��P� & � ��' . . ��� $( arrow�� � �� �	#FFFFFFFF^� 3 �� 4 �� *	IsPressed+ �� *Self+- true�� 4 �� *
IsEditable+ �� "5 ��	- false.0��� $( templateRoot�� � �� �	#19000000�� $( templateRoot�� � �� �	#19000000^� 3 �� 4 �� *	IsPressed+ �� *Self+- true�� 4 �� *
IsEditable+ �� "5 ��- true.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ���� $( splitBorder��8   � ���� $( splitBorder��8   � ��P� & � {�' .  . ��� $( arrow��8   � ��^� 3 �� 4 �� *	IsEnabled+ �� *Self+	- false�� 4 �� *
IsEditable+ �� "5 ��	- false.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ��^� 3 �� 4 �� *	IsEnabled+ �� *Self+	- false�� 4 �� *
IsEditable+ �� "5 ��- true.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ���� $( splitBorder��8   � ���� $( splitBorder��8   � ���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$
 Auto=���  � ��$
 Auto=���  � ��$ 6,3,5,3q���  � �� . ��  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled .  ��  � ��8  D P� & �@��
IsEditable' . . ���  � �� .  ��  � ��$ 2q���  � ��8  �� " d�.���  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  �@��	ClickMode$ Press=���  � �� �� " d�.R��� $ templateRoot�� . #��z��8��  ._��� $ splitBorder��#��� r� . $��0q�$��Right=�$��1q����	#00FFFFFF���	#02000000._�F� $ arrow��$��Center=�$��0q�$��Center=�F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� % ^� 3 �� 4 �� *
IsEditable+ �� "5 ��- true�� 4 �� *IsMouseOver+ �� *Self+	- false�� 4 �� *	IsPressed+ �� *Self+	- false�� 4 �� *	IsEnabled+ �� *Self+- true.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ���� $( splitBorder��8   � ���� $( splitBorder��8   � ��P� & �@J�IsMouseOver' . . ��� $( arrow�� � �� �	#FFFFFFFF^� 3 �� 4 �� *IsMouseOver+ �� *Self+- true�� 4 �� *
IsEditable+ �� "5 ��	- false.0��� $( templateRoot�� � �� �	#19000000�� $( templateRoot�� � �� �	#19000000^� 3 �� 4 �� *IsMouseOver+ �� *Self+- true�� 4 �� *
IsEditable+ �� "5 ��- true.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ���� $( splitBorder��8   � ���� $( splitBorder��8 	  � ��P� & � ��' . . ��� $( arrow�� � �� �	#FFFFFFFF^� 3 �� 4 �� *	IsPressed+ �� *Self+- true�� 4 �� *
IsEditable+ �� "5 ��	- false.0��� $( templateRoot�� � �� �	#19000000�� $( templateRoot�� � �� �	#19000000^� 3 �� 4 �� *	IsPressed+ �� *Self+- true�� 4 �� *
IsEditable+ �� "5 ��- true.0��� $( templateRoot��8 
  � ���� $( templateRoot��8   � ���� $( splitBorder��8   � ���� $( splitBorder��8   � ��P� & � {�' .  . ��� $( arrow��8   � ��^� 3 �� 4 �� *	IsEnabled+ �� *Self+	- false�� 4 �� *
IsEditable+ �� "5 ��	- false.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ��^� 3 �� 4 �� *	IsEnabled+ �� *Self+	- false�� 4 �� *
IsEditable+ �� "5 ��- true.0��� $( templateRoot��8   � ���� $( templateRoot��8   � ���� $( splitBorder��8   � ���� $( splitBorder��8   � ���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��#��z��#��z��#��z�� . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z��% P� & �@��IsDefaulted' . . ��� $( border��# � �� � ��P� & �@J�IsMouseOver' . . ��� $( border��8   � ���� $( border�� � �� �	#02000000P� & � ��' . . ��� $( border��8   � ���� $( border�� � �� �	#02000000P� & � {�' .  . ��� $( border��8   � ���� $( border��8   � ���� $( contentPresenter��8   � ���� $
 	#3D26A0DA���� $
 	#FF26A0DA���� $
 	#FF707070���� $
 	#0A000000���� $
 	#21000000���� $
 	#FF26A0DA���� $
 	#3D26A0DA���UQF1 M 10.0,1.2 L 4.7,9.1 L 4.5,9.1 L 0,5.2 L 1.3,3.5 L 4.3,6.1L 8.3,0 L 10.0,1.2 Z��� $
 	#FF212121���� " m�.R��� $ templateRoot��#��z��#��z��#��z��$��22�� . ._�� $��-1q� �� $��22��$E MenuItemIconColumnGroup��$
��Auto ��� $��13 ��� $��* ��� $��30 ��� $E MenuItemIGTColumnGroup��$
��Auto ��� $��20 �.+��� $
 Icon��$
��Icon��$��Center=�$��16��$��3q�# z $��Center=�$��16���� $ 
GlyphPanel��$��1q�}�.  $��Center=�$��22��$��-1,0,0,0q�$y�Hidden=�$��Center=�$��22��8��  8�� ._�F� $ Glyph�����	#FFFFFFFF$��LeftToRight=�$��11��$��10��8�� �� $ menuHeaderContainer��$��2��$��Header��$
��Left=�#��z����. # z $��Center=��� $F menuGestureText��$��4��#��z��$	 0.7Q�#��zG $��Center=�% P� ' Z� & �@m�Icon. ��� $
( Icon�� � y�$ 	Collapsed=�P� & �@m�	IsChecked' . . ��� $( 
GlyphPanel�� � y�$ Visible=��� $
( Icon�� � y�$ 	Collapsed=�P� & �@m�IsHighlighted' . . ��� $( templateRoot��8   � ���� $( templateRoot��8   � ��P� & � {�' .  . ��� $( templateRoot��8   � ���� $( Glyph��8   � ��]� + �� , �@m�IsHighlighted- . �� , � {�- .  ./��� $( templateRoot��8   � ���� $( templateRoot��8   � ���� $
 	#FF999999���� $
 	#FFD7D7D7���M 0,4 L 3.5,0 L 7,4 Z��� " ��H Z� .���  �@��	ClickMode$ Hover=���  � �� �� " ��.R��� $ templateRoot�����	#00FFFFFF$��1q����	#00FFFFFF . ._��� $��Center=�$��6q�$��Center=�l� �M 0,0 L 3.5,4 L 7,0 Z��� " ��H Z� .���  � ��$ Hidden=���  � ��$
 Auto=���  � �� �� " ��.R��  .  �� $��* �I �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��0��$��1��._��� #J z��#��z���� $��0��#��ZK |�.  $��0��8��  ����  �� *TemplatedParent+y�`� $L 0��$M Visibility.Collapsed��8N  .1��� $)O #ComputedVerticalScrollBarVisibility� �� *TemplatedParent+�� $O VerticalOffset� �� *TemplatedParent+�� $O ExtentHeight� �� *TemplatedParent+�� $O ViewportHeight� �� *TemplatedParent+.��F� 8�� 8�� �� $��0��#��ZP |�.  $��2��8�� ����  �� *TemplatedParent+y�`� $	L 100��$M Visibility.Collapsed��8N  .1��� $)O #ComputedVerticalScrollBarVisibility� �� *TemplatedParent+�� $O VerticalOffset� �� *TemplatedParent+�� $O ExtentHeight� �� *TemplatedParent+�� $O ViewportHeight� �� *TemplatedParent+.��F� 8�� 8�� �� " m�.R��� $ templateRoot��#��z��#��z��#��z�� . ._�� $��Center=� �� $
��Auto ��� $
��Auto �.+��� $
 Icon��$
��Icon��$��Center=�$��16��$��3q�# z $��Center=�$��16��F� $ 
GlyphPanel��#��z��$��LeftToRight=�$��3q�$y�	Collapsed=�$��Center=�8��  �� $��1��$��Header��#��z����. # z � $ 
PART_Popup�� . |�.  #��� -�$��Bottom=����� *IsSubmenuOpen+ �� *TemplatedParent+Q �� $  templateRoot��.���� $ SubMenuBorder��$��1q�$ 2q�8�� 8�� ._��� $ SubMenuScrollViewer����C� *�� $ MenuScrollViewer��" �+.��� $ Enabled=�.+��� $
��Left=�$��0��$	��Top=�$��0��.+��� $ 
OpaqueRect������ *
Background+$  SubMenuBorder������ *ActualHeight+$  SubMenuBorder������ *ActualWidth+$  SubMenuBorder���� $
��Left=�$��29,2,0,2q�$��1��8�� �� $! ItemsPresenter��$" Cycle=�# . # z $$ Cycle=�% P� "& �@m�IsSuspendingPopupAnimation' . . ��� $( 
PART_Popup�� � ��$
 None=�P� ' Z� & �@m�Icon. ��� $
( Icon�� � y�$ 	Collapsed=�P� & �@m�	IsChecked' . . ��� $( 
GlyphPanel�� � y�$ Visible=��� $
( Icon�� � y�$ 	Collapsed=�P� & �@m�IsHighlighted' . . ��� $( templateRoot��8   � ���� $( templateRoot��8   � ��P� & � {�' .  . ��� $( templateRoot��8   � ���� $( 
GlyphPanel��8   � ��P� $) SubMenuScrollViewer��& � ��' .  . ��� $( 
OpaqueRect�� �� *VerticalOffset+$  SubMenuScrollViewer�� �@��Top�� $( 
OpaqueRect�� �� *HorizontalOffset+$  SubMenuScrollViewer�� �@��Left�� " m�.R��� $ templateRoot��#��z��#��z��#��z�� . ._�� $��Center=� �� $
��Auto ��� $
��Auto �.+��� $
 Icon��$
��Icon��$��Center=�$��16��$��3q�# z $��Center=�$��16��F� $ 
GlyphPanel��$��LeftToRight=�$��3q�$y�	Collapsed=�$��Center=�8��  8�� �� $��1��$��Header��#��z����. # z % P� ' Z� & �@m�Icon. ��� $
( Icon�� � y�$ 	Collapsed=�P� & �@m�	IsChecked' . . ��� $( 
GlyphPanel�� � y�$ Visible=��� $
( Icon�� � y�$ 	Collapsed=�P� & �@m�IsHighlighted' . . ��� $( templateRoot��8   � ���� $( templateRoot��8   � ��P� & � {�' .  . ��� $( templateRoot��8   � ���� $( 
GlyphPanel��8   � ��]� + �� , �@m�IsHighlighted- . �� , � {�- .  ./��� $( templateRoot��8   � ���� $( templateRoot��8   � ���M 0,0 L 4,3.5 L 0,7 Z��� " m�.R��� $ templateRoot��#��z��#��z��#��z��$��22�� . ._�� $��-1q� �� $��22��$E MenuItemIconColumnGroup��$
��Auto ��� $��13 ��� $��* ��� $��30 ��� $E MenuItemIGTColumnGroup��$
��Auto ��� $��20 �.+��� $
 Icon��$
��Icon��$��Center=�$��16��$��3q�# z $��Center=�$��16���� $ 
GlyphPanel��$��1q�$��22��$��-1,0,0,0q�$y�Hidden=�$��Center=�$��22��8��  8�� ._�F� $ Glyph��#��� < $��LeftToRight=�$��11��$��9��8�� �� $��2��$��Header��$
��Left=�#��z����. # z $��Center=��� $��4��#��z��$	 0.7Q�#��zG $��Center=�F� $ 
RightArrow��$��5��$
��Left=�$��10,0,0,0q�$��Center=�8�� 8�� � $ 
PART_Popup�� . |�.  $R -2��#��� -�$��Right=�$S -3������ *IsSubmenuOpen+ �� *TemplatedParent+.���� $ SubMenuBorder��$��1q�$ 2q�8�� 8�� ._��� $ SubMenuScrollViewer����C� *�� $ MenuScrollViewer��" �+.��� $ Enabled=�.+��� $
��Left=�$��0��$	��Top=�$��0��.+��� $ 
OpaqueRect������ *
Background+$  SubMenuBorder������ *ActualHeight+$  SubMenuBorder������ *ActualWidth+$  SubMenuBorder���� #��� ��$
��Left=�$��29,2,0,2q�$��1���� $! ItemsPresenter��$" Cycle=�# . # z $$ Cycle=�% P� "& �@m�IsSuspendingPopupAnimation' . . ��� $( 
PART_Popup�� � ��$
 None=�P� ' Z� & �@m�Icon. ��� $
( Icon�� � y�$ 	Collapsed=�P� & �@m�	IsChecked' . . ��� $( 
GlyphPanel�� � y�$ Visible=��� $
( Icon�� � y�$ 	Collapsed=�P� & �@m�IsHighlighted' . . ��� $( templateRoot�� � �� �	#00FFFFFF�� $( templateRoot��8   � ��P� & � {�' .  . ��� $( templateRoot��8   � ���� $( Glyph��8 	  � ���� $( 
RightArrow��8 
  � ��P� $) SubMenuScrollViewer��& � ��' .  . ��� $( 
OpaqueRect�� �� *VerticalOffset+$  SubMenuScrollViewer�� �@��Top�� $( 
OpaqueRect�� �� *HorizontalOffset+$  SubMenuScrollViewer�� �@��Left�� " m�.���  � �� �� *HorizontalContentAlignment+ �� "5 ����  � �� �� *VerticalContentAlignment+ �� "5 ����  � �� �	#00FFFFFF��  � �� �	#00FFFFFF��  � ��$ 1q���  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled .  ��  � �� C� *�� $ SubmenuItemTemplateKey��" m�+D P� & �@m�Role$' TopLevelHeader=�. ���  � �� �	#00FFFFFF��  � �� �	#00FFFFFF��  � ��8   ��  � �� C� *�� $ TopLevelHeaderTemplateKey��" m�+��  � ��$	 6,0q�P� & �@m�Role$' TopLevelItem=�. ���  � ��8  ��  � ��8  ��  � ��8  ��  � �� C� *�� $ TopLevelItemTemplateKey��" m�+��  � ��$	 6,0q�P� & �@m�Role$' SubmenuHeader=�. ���  � �� C� *�� $ SubmenuHeaderTemplateKey��" m�+.��� -   $
6 grid�� . .+��� -   T ��Name$T imgBg��$	 0.5Q�$	��512��$	��512��$��TRXLogos/TRX512.png��$��92,-86,88,-107q�r� -   U r�Name$U CustomBg��V r� LoadedBehavior$
V Play=�W r� Stretch$
W Fill=�o� $
��Left=�$��20��$	��Top=�$	��687�����	#FFFFFFFF#���  ��Z� .@�m� -   X m�Name$X 
editorMenu��$��Editor��#���  .@�m� -   $��Paste��m� -   $
��Copy��m� -   $��Save Script��m� -	   $X optionsMenu��$��Options��#���  .@�m� -
   $X topmostItem��$��Top Most��Y m� IsCheckableY . #��� E m� -   $X autoopacityItem��$��Auto Opacity��Y . #��� E m� -   $X hidelogoItem��$��Hide BG Logo��Y . #��� E m� -   $X bgEditorItem��$��	BG Editor��m� -   $X killRblxItem��$��Kill Roblox��m� -   $X AutoAttachMenuItem��$��Auto Attach��Y . m� -   $X joinDiscord��$��- Join Discord -��m� -   $X scriptsMenu��$��Fast Scripts��#���  .@�m� -   $X infiniteyield��$��Infinite Yield��m� -   $X 
btoolsItem��$��BTools���� -   Z ��Name$Z 
EditorTabs��$y�Visible=�$��0q� F Tabs#��� F $��6,68,157,36q���Z� ��Z� ��Z� .@��� -   [ ��Name$[ 	OutputTab��$��New Tab�� G Tab#��� G $y�	Collapsed=���Z� .��^ ZICSharpCode.AvalonEdit, Version=6.1.3.50, Culture=neutral, PublicKeyToken=9cc39be672370310'  !ICSharpCode.AvalonEdit.TextEditor  ?
avalonEdit.http://icsharpcode.net/sharpdevelop/avalonedit  -   \  Name$\ 
TextEditor��$��consolas)�$
��12px(����	#7F1D1D1D]   SyntaxHighlightingM  GICSharpCode.AvalonEdit.Highlighting.HighlightingDefinitionTypeConverter$	] LUA ���	#FFFFFFFF"^   VerticalScrollBarVisibility$
^ Auto=�$_   HorizontalScrollBarVisibility$
_ Auto=�$��3q�`   LineNumbersForeground` �	#FFB4B4B4���	#FF2B2B2B$��1q�a   ShowLineNumbersa . �� -   b ��Name$b 	scriptBox��$��1q����	#FF2B2B2B$��
0,68,10,10q����	#DDFFFFFF���	#7F1D1D1D#���  c J� RenderTransformOrigin$c 0.5,0.5&�$��Right=�$	��139��d � ContextMenud .   (SourceChord.FluentWPF.AcrylicContextMenu  .@�m� -   $X refreshItem��$��Refresh���� -   e ��Name$e execBtn��$��Execute�� H ButtonRevealStyle#��[H $��28��$��8,0,0,7q�$��Bottom=�$	��155�����	#7F1D1D1D���	#FF616161���	#FFFFFFFF$
��Left=��� -   $e 
opnfileBtn��$��	Open File��#��[H $��28��$��	0,0,404,7q�$��Bottom=�$	��115�����	#7F1D1D1D���	#FF616161���	#FFFFFFFF$��Right=��� -   $e 	svfileBtn��$��	Save File��#��[H $��28��$��	0,0,284,7q�$��Bottom=�$	��115�����	#7F1D1D1D���	#FF616161���	#FFFFFFFF$��Right=��� -   $e clrBtn��$��Clear��#��[H $��28��$��	0,0,159,7q�$��Bottom=�$	��120�����	#7F1D1D1D���	#FF616161���	#FFFFFFFF$��Right=��� -   $ dllchangerPnl��$��1q����	#FF2B2B2B$��	0,25,12,0q����	#7F6C6C6C$��Right=�$	��137��$	��Top=�$��31��._��� $ 1Q�$��-1,-1,108,0q�$��Icons\dllFile.png���� -   f ��Name$f 	dllchange��$��Center=�$
��Left=�$��Right=�$��	0,25,12,0q�$	��Top=�$	��137��$��31�����	#FFFFFFFF I ComboBoxRevealStyle#��[I $��10(���Z� ��Z� .@��� $��       Seliware���� $��       TRXQ���� -   $ navigatorPnl��$��1q����	#FF2B2B2B$��246,7,246,0q����	#7F1D1D1D$c 0.5,0.5&�$��Center=�$	��200��$	��Top=�$��49��$	��200��$��49���� -    $e scripthubBtn��g � ToolTip$g Script Catalog��$��2q�$��0��$��246,7,378,0q�$��68��$��49�����	#FFFFFFFF$	��Top=�#��[H $��Center=�$��68����Z� ���� .R��� $	 0.8Q�$��./Icons/scripthub.png��$��48��$��48���� -!   $e 
creditsBtn��$g Credits��$��2q�$��0��$��314,7,312,0q�$��66��$��49�����	#FFFFFFFF$	��Top=�#��[H $��Center=�$��66����Z� ���� .R��� $	 0.8Q�$��Icons/credits.png��$��48��$��48���� -"   $e 	injectBtn��$g Inject��$��2q�$��0��$��380,7,246,0q�$��66��$��49�����	#FFFFFFFF$	��Top=�#��[H $��Center=�$��66����Z� ���� .R��� $	 0.8Q�$��Icons/inject.png��$��48��$��48��