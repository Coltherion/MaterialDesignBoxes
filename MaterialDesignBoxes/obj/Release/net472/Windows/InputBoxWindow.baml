   M S B A M L   `   `   `  ����   MaterialDesignBoxes(    "MaterialDesignBoxes.InputBoxWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $��Center=�  � AllowsTransparency$
  True��$��14(� � 
ResizeMode$ NoResize=� � SizeToContent$ WidthAndHeight=� J� SnapsToDevicePixels$
 True�� � Title$ InputBoxWindow�� � Topmost$
 True�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 	Resources 	 �� MergedDictionaries/  )MaterialDesignThemes.Wpf.CustomColorTheme
   	BaseTheme   PrimaryColor   SecondaryColor �� Source �� 
TargetType �� Property   PrimaryHueMidBrush �� Value  MaterialDesignPaper  CustomWindowStyle �� 
TargetType  PrimaryHueDarkBrush �� CornerRadius�� -   ThemeDictionary��	   	
 Light Gray	 White�� $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?��� $k epack://application:,,,/MaterialDesignBoxes;component/Dictionaries/MaterialDesignThemes.Overrides.xaml?��� $Z Tpack://application:,,,/MaterialDesignBoxes;component/Dictionaries/CustomButtons.xaml?�%�   '_�       &	 J     �� " _�.���  � ��# �   ��  � ��# �  ��  � ��$ 0q��� " �.���  � �� �� " �.R��� #���  #���  $	��0.5q�$ 10��._��� ����  �� ResourceKey$ CustomWindowStyle��.��� -   $��InputBoxMainSection�� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto �.+�� -   $��InputBoxHeader��$��0�� � ColumnDefinitions �� $��* ��� $
��Auto �.+��� -   $��InputBoxHeaderBorder��#���   $ 7,7,0,0���� -   $��InputBoxTitle��$��Center=�$��Medium"� �� Padding$ 7,2,0,1q�$��Title������  �� ElementName$ InputBoxHeaderBorder�� �� Path$ 
Background�  LuminanceConverter �� 	Converter# [ �� -   $��ButtonClose��$��Right=�  CloseButton#��[ ���� $ InputBoxTitle��$ 
Foreground�� $��1�� �� $
��Auto ��� $
��Auto ��� $
��Auto � �� $��* �.+��� -   $��InputBoxQuery��$��
12,12,12,6q�$��Input Box Query:���� $��1��$	��500��$
��Auto=�.���� -   $��InputBoxField��$	��500��$��12,12q�$��Center=�$��Normal"�
���   �$��5,5,30,5q�$��Input�� �� TextWrapping$
 Wrap=��� -	   $��ButtonClear��$��1��$��0,0,10,0q�$��Right=�  ClearButton#��[  � ToolTip$ Clear���� -
   $��InputBoxCombobox��$��2��$	��400��$��12,12q� �� $ SelectedItem� �� RelativeSource �� *Self+� -   $��InputBoxButtons��$��2��$��15,12q� �� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto �.+��� -   $��ButtonPaste��$��0��$��0,0,2,0q�$
��Left=�  MaterialDesignIconButton#��[ $ Paste from Clipboard��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ContentPaste=��� -   $��ButtonOk��$��2��$��0,0,10,0q�$��OK��  MaterialDesignPaperButton#��[ �� -   $��ButtonCancel��$��3�����#969696$��Cancel��#��[ 