   M S B A M L   `   `   `  ���� D  @FluentWPF, Version=0.9.0.1, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF  > :TRX, Version=1.9.7.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TRXTRX    TRX.BGEditor   =fw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     #localclr-namespace:TRX     -   )   #SourceChord.FluentWPF.AcrylicWindow    NoiseOpacity$  0Q�*   $SourceChord.FluentWPF.PointerTracker   Enabled .    AcrylicWindowStyle$
 None=�   Enabled .  � ShowInTaskbar .  � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � Topmost .  � WindowStartupLocation$ CenterScreen=�	 � Title$		 TRX��$	��253��$	��483�����	#4C1D1D1D
 � 	Resources
  !  SliderThumb.Static.Foreground �� Color $  SliderThumb.MouseOver.Background   SliderThumb.MouseOver.Border " SliderThumb.Pressed.Background  SliderThumb.Pressed.Border # SliderThumb.Disabled.Background  SliderThumb.Disabled.Border ! SliderThumb.Static.Background  SliderThumb.Static.Border 	 SliderThumbHorizontalTop �� 
TargetType � UseLayoutRounding F�Name �� Stretch J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName �� Value �� Property 
 SliderThumbHorizontalBottom  SliderThumb.Track.Border   SliderThumb.Track.Background  RepeatButtonTransparent2 �� 
TargetType   SliderThumbHorizontalDefault  SliderHorizontal ��Name � RowDefinitions m�Name m� Fill m� 	Placement ��Name ]�Name ]� DecreaseRepeatButton  �� DecreaseLarge! ]� IncreaseRepeatButton" �� IncreaseLarge# ]� Thumb$ n�Name% � OverridesDefaultStyle  SliderThumbVerticalLeft  SliderThumbVerticalRight  SliderThumbVerticalDefault  SliderVertical& � ColumnDefinitions  SliderStyle1' �� Triggers�� %�  &	        &	      &	 *     &	 ?     &	 T     &	 i     &	 ~     &	 �     &	 �     &		 �     7  7  7  7  7  7  7  7  &	
 �    7  7  7  7  7  7  7  7  &	 �    &	 �    &	     &	 �    7  7  7  7  7  7  7  7  &	 �    7  7  7  7 	 7 
 &	 �    7  7  7  7  7  7  7  7  &	 �    7  7  7  7  7  7  7  7  &	 �    7  7  7  7  7  7  7  7  &	 ,    7  7  7  7  7  7  7  &	     7   7  7  �� $ 	#FFE5E5E5���� $ 	#FFDCECFC���� $ 	#FF7Eb4EA���� $ 	#FFDAECFC���� $ 	#FF569DE5���� $ 	#FFF0F0F0���� $ 	#FFD9D9D9���� $ 	#FFF0F0F0���� $ 	#FFACACAC���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip�������    ��[ �    ��[ `�S `�S �`�S     �ا ��[ �ا ��[ ��ا ��[ �ا ���ا ����ا �������    ����[ ��[ 	$
 Fill=� . $��1�� . $��Center=�8��  8��  P�  �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip�������     � �     � `�S ��`�S ���`�S ���ا  � �ا  � ��ا  � �ا �ا ��ا     �         �  � 	$
 Fill=� . $��1�� . $��Center=�8��  8��  P�  �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� $ 	#FFD6D6D6���� $ 	#FFE7EAEA���� " ��.���  �@�OverridesDefaultStyle . ��  � �� �	#00FFFFFF��  � |� .  ��  � �� .  ��  � �� �� " ��.R��� #��z��#��z��#��z���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip��d����        �        �ا �ا ��ا     �ا ���ا ����ا �������    ��	$
 Fill=� . $��1�� . $��Center=�8��  8��  P�  �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� " ��.R��� $ border��#��z��#��z��#��z�� . ._��  �� $
��Auto ��� $
��Auto �#��z���� $
��Auto �.+�m� $ TopTick��# z��$��4��$��0,0,0,2q�$	 Top=�$��0��$y�	Collapsed=�m� $ 
BottomTick��# z��$��4��$��0,2,0,0q�$ Bottom=�$��2��$y�	Collapsed=��� $ TrackBackground��$��1q�$	��4.0��$	��5,0q�$��1��$��center=����	#CC515151���	#FF292929._��� $��-6,-1q�.+��� $ PART_SelectionRange��#��� ��$	��4.0��$y�Hidden=�]� $ 
PART_Track��$��1�� �� #��Z  8��  ! �� #��Z" 8�� # n� $$ Thumb��|�.  $��18��% . $��Center=�$��11��8��  P�  �@��TickPlacement$ TopLeft=�. ��� $ TopTick�� � y�$ Visible=��� $ Thumb��8   � ���� $ TrackBackground�� � ��$ 5,2,5,0q�P�  �@��TickPlacement$ BottomRight=�. ��� $ 
BottomTick�� � y�$ Visible=��� $ Thumb��8   � ���� $ TrackBackground�� � ��$ 5,0,5,2q�P�  �@��TickPlacement$
 Both=�. ��� $ TopTick�� � y�$ Visible=��� $ 
BottomTick�� � y�$ Visible=�P�  �@��IsSelectionRangeEnabled . . ��� $ PART_SelectionRange�� � y�$ Visible=�P�  �@J�IsKeyboardFocused . . ��� $ Thumb�� � �� �	#FF0000FF�� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip���������[ �ا Ӏ�[ �ا `�S `�S �    `�S ��[ ��[ Ӏ�[     ����Ӏ�    ���ا ���ا Ӏ��ا ��[ �ا ��[ �ا 	$
 Fill=�8��  8��  P�  �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip������� � �ا � � �ا ��`�S ��`�S Ӏ�`�S  �  � � �     �        �ا �ا �    �ا  � �ا  � �ا 	$
 Fill=�8��  8��  P�  �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip��+���� �  � ѠI � ѠI�y� � � �y� 	$
 Fill=�8��  8��  P�  �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P�  � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� " ��.R��� $ border��#��z��#��z��#��z�� . ._�� & �� $
��Auto ��� #��z��$
��Auto ��� $
��Auto �.+�m� $ TopTick��$��0��# z��$��0,0,2,0q�$
 Left=�$y�	Collapsed=�$��4��m� $ 
BottomTick��$��2��# z��$��2,0,0,0q�$ Right=�$y�	Collapsed=�$��4���� $ TrackBackground��$��1q�$��1��$��center=�$	��0,5q�$	��4.0��8��  8�� ._��� $��-1,-6q�.+��� $ PART_SelectionRange��#��� ��$y�Hidden=�$	��4.0��]� $ 
PART_Track��$��1�� �� #��Z  8�� ! �� #��Z" 8�� # n� $$ Thumb��|�.  $��11��% . $	��Top=�$��18��8��  P�  �@��TickPlacement$ TopLeft=�. ��� $ TopTick�� � y�$ Visible=��� $ Thumb��8   � ���� $ TrackBackground�� � ��$ 2,5,0,5q�P�  �@��TickPlacement$ BottomRight=�. ��� $ 
BottomTick�� � y�$ Visible=��� $ Thumb��8   � ���� $ TrackBackground�� � ��$ 0,5,2,5q�P�  �@��TickPlacement$
 Both=�. ��� $ TopTick�� � y�$ Visible=��� $ 
BottomTick�� � y�$ Visible=�P�  �@��IsSelectionRangeEnabled . . ��� $ PART_SelectionRange�� � y�$ Visible=�P�  �@J�IsKeyboardFocused . . ��� $ Thumb�� � �� �	#FF0000FF�� " ��.���  �@��IsPressAndHoldEnabled .  ��  � �� �	#00FFFFFF��  � �� �	#00FFFFFF��  � ��8   ��  � ��8  ' P�  �@��Orientation$ Vertical=�. ���  � ��8  .��� .+��� -   ( ��Name$( logoImg��$
��Left=�$��68��$	��Top=�$��68��$��TRXLogos\TRX68.png��$��6,-1,0,0q��� -   ) ��Name$) linkLbl��$
��Left=�$��	3,217,0,0q�$	��Top=����	#FFDCD3D3$��Segoe UI Semilight)�$��16(���Z� .���� -   $��https://trx-roblox.com?����	#FF1B86F1.�trx-roblox.com�� -   * ��Name$* exitBtn��  ButtonRevealStyle#��[ $��X��$
��Left=�$��	447,0,0,0q�$	��Top=�$��35��$��35��$��16(����	#FFFFFFFF��Z� ��Z� �� -   $) titleLbl��$��Background Editor��$
��Left=�$��	80,12,0,0q�$	��Top=�$��16(����	#FFFFFFFF$��Segoe UI Semibold)��� -   $) textLbl��$��Enter background URL:��$
��Left=�$��	10,67,0,0q�$	��Top=�$��16(����	#FFFFFFFF$��32��$	��463���� -   $* okBtn��#��[ $��OK��$
��Left=�$��372,218,0,0q�$	��Top=�$	��101��$��26�����	#80343434���	#FFFFFFFF�� -	   + ��Name$+ urlTB��  TextBoxRevealStyle#��[ $
��Left=�$��35��$��
13,103,0,0q�, �� TextWrapping$
, Wrap=�$	��Top=�$	��455�����	#B2272727- �� SelectionBrush- �	#FFFFFFFF���	#FFFFFFFF���	#33000000�� -
   $) descLbl��$ ��Select background opacity:��$
��Left=�$��
10,138,0,0q�$	��Top=�$��16(����	#FFFFFFFF$��32��$	��463���� -   . ��Name$. opacitySlider��$
��Left=�$��	9,177,0,0q�$	��Top=�$	��404��#���  / � Maximum$/ 1Q�0 � Value$0 1Q�1 � SmallChange$1 11Q�2 � LargeChange$	2 0.3Q�3 �� TickFrequency$3 10Q���Z� ��Z� ��Z� �� -   $) valueLbl��$
��100%��$
��Left=�$��422,170,0,0q�$	��Top=�$��16(����	#BF939393$��32��$��49����Z� 