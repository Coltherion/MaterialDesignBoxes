   M S B A M L   `   `   `  ���� N  JMaterialDesignBoxes, Version=3.1.3.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MaterialDesignBoxesMaterialDesignBoxes  *    $MaterialDesignBoxes.MessageBoxWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     3local!clr-namespace:MaterialDesignBoxes     _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��450��$��Center=�  � AllowsTransparency$
  True��$��14(� � 
ResizeMode$ NoResize=� � SizeToContent$ Height=� J� SnapsToDevicePixels$
 True�� � Title$ MessageBoxWindow�� � Topmost$
 True�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 	Resources 	 �� MergedDictionaries/  )MaterialDesignThemes.Wpf.CustomColorTheme
   	BaseTheme   PrimaryColor   SecondaryColor �� Source   CustomWindowStyle �� 
TargetType �� Property �� Value �� 
TargetType  MaterialDesignPaper  PrimaryHueDarkBrush �� CornerRadius,   &MaterialDesignBoxes.LuminanceConverter  LuminanceConverter�� -   ThemeDictionary��	   	
 Light Gray	 White�� $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?��� $k epack://application:,,,/MaterialDesignBoxes;component/Dictionaries/MaterialDesignThemes.Overrides.xaml?��� $Z Tpack://application:,,,/MaterialDesignBoxes;component/Dictionaries/CustomButtons.xaml?�%r   &	        &	 Y     �� " �.���  � �� �� " �.R��� #���  #���  $	��0.5q�$ 10��._���   ����  �� ResourceKey$ CustomWindowStyle��.��� -   $��MessageBoxMainSection�� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto �.+�� -   $��MessageBoxHeader��$��0�� � ColumnDefinitions �� $��* ��� $
��Auto �.+��� -   $��MessageBoxHeaderBorder��  PrimaryHueMidBrush#���  $ 7,7,0,0���� -   $��MessageBoxTitle��$��Center=�$��Medium"� �� Padding$ 9,2,0,1q�$��Title������  �� ElementName$ MessageBoxHeaderBorder�� �� Path$ 
Background� �� 	Converter# [ �� -   $��ButtonClose��$��Right=�  CloseButton#��[ ���� $ MessageBoxTitle��$ 
Foreground�� $��1�� �� $
��Auto ��� $��* � �� $
��Auto ��� $��* �.+�'  !MaterialDesignThemes.Wpf.PackIcon  -   $��MessageBoxIcon��$��0��$��2��$��0��$��45��$��45��$��	12,0,12,0q�$��Right=�$��Center=�#���     Kind$ MessageText=��� -   $��MessageBoxScrollViewer��$��0��$��1��$	��100��$	��500��$
��Auto=�.���� -	   $��MessageBoxText��$
��12,6q�$��Center=�$��Normal"�
���   �$ 3q�$��Message��$
��Wrap=��� -
   $��MessageCheckBox��$��1��$��1��$��12,12q�$��Custom Checkbox��  MaterialDesignCheckBox#��[ � $��2��$��15,12q� �� $��* � �� $��* ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -   $��BtnCopyMessage��$��0��$
��Left=�  MaterialDesignIconButton#��[  � ToolTip$ Copy to Clipboard��.��  $ ContentCopy=��� -   $��Button1��$��1��$��Button1��  MaterialDesignPaperButton#��[ �� -   $��Button2��$��2��$��10,0,0,0q�$��Button2��#��[ �� -   $��Button3��$��3��$��10,0,0,0q�$��Button3��#��[ 