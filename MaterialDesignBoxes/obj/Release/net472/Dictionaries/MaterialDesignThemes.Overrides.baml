   M S B A M L   `   `   `  ���� _  [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a{Sclr-namespace:MaterialDesignThemes.Wpf.Converters;assembly=MaterialDesignThemes.Wpf#MaterialDesignThemes.Wpf.Converters  N JMaterialDesignBoxes, Version=3.1.3.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MaterialDesignBoxesMaterialDesignBoxes eHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089,   &MaterialDesignBoxes.LuminanceConverter   LuminanceConverter  MaterialDesignPaperButton  �� BasedOn �� 
TargetType �� Property �� Value  PrimaryHueDarkBrush �� RelativeSource �� Path �� 	Converter �� 
TargetType J� 	CacheMode	 ��Name
 �� CornerRadius J� Effect9   3MaterialDesignThemes.Wpf.Converters.ShadowConverter   Instance%   MaterialDesignThemes.Wpf.Ripple �� ContentStringFormat J� SnapsToDevicePixels J� Clip  BorderClipConverter `� 	Converter �� ElementName �� Triggers P� Property P� Value �� 
TargetName+   %MaterialDesignThemes.Wpf.ShadowAssist �� Mode  BrushOpacityConverter �� ConverterParameter  MaterialDesignIconButton � 	Resources'   !MaterialDesignThemes.Wpf.PackIcon ��Name J� Opacity �� RadiusX �� RadiusY J� IsHitTestVisible  ClearButton0   *MaterialDesignThemes.Wpf.PackIconExtension   Kind   Size  �� Value! �� Binding  MaterialDesignCheckBox  FocusVisual" �� AncestorType )	 %MaterialDesignValidationErrorTemplate 
 Key# �� 
TargetName$ �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame% O� Value& O� KeyTime' �Name( � ColumnDefinitions) F�Name* A�Name+ �� Left
, �� Top- J� RenderTransformOrigin. ��Name/ ^� 
Conditions0 �� Binding1 �� Value2 N� EnterActions 	 Click  OptionMarkFocusVisual " MaterialDesignCheckBoxDisabled & "MaterialDesignValidationErrorBrush�� F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     b
convertersSclr-namespace:MaterialDesignThemes.Wpf.Converters;assembly=MaterialDesignThemes.Wpf  +local!clr-namespace:MaterialDesignBoxes  PwpfHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf  %L  &	        &	      7  7   7  7  &	 $    7  &	 �    7  &	 �
    7  7  7 	 7  7     �� 8    " ��.���  � ��$ 28����  � ��$ 95����  � ��$ 117.5����  � ��$ 2,0,2,1q���  � ��# �  ��  � �� ��  �� *Self+$ 
Background�8  ��  � �� �� " ��.R�� .+���  ��  �� *Self+$" (wpf:ShadowAssist.CacheMode)�.u�� .+��� $	 
background��#��z��
 �� $% (wpf:ButtonAssist.CornerRadius)� �� *TemplatedParent+ ��  �� *TemplatedParent+$$ (wpf:ShadowAssist.ShadowDepth)�# Z   #��z��#��z��#��z��# z #��z��$|�False��#��z��# z  `� 8  .1��� $ border��$ ActualWidth��� $ border��$ ActualHeight��� $ border��$ CornerRadius��� $ border��$ BorderThickness� P�  �@J�IsMouseOver$
 true��. ��� $ 
background�� �@ Darken$
 True���� $ 
background�� �� *
Background+ �� $ TemplatedParent=�8  $
 0.75�� � ��P�  � {�$ false��. ���  �@J�Opacity$
 0.23Q�P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$ Arrow���� 8    " ��.���  � ��$ 0q���  � ��$ 30����  � ��$ 30����  � ��# �  ��  � �� �� " �� ���� '        "  .���  � ��$ 23����  � ��$ 23��.R�� .+��� $ overlay��#��z��$ .1Q�$ 5��$ 5��$y�Hidden=�  #��z��#��z��$
}�True��#��z��# z #��z��$|�False��#��z��# z  �� $ GeometryEllipse��$ RenderedGeometry��� $ GeometryRectangle��
������ $|�False��$ False�� P�  �@J�IsMouseOver$
 true��. ��� $ overlay�� � y�$ Visible=�P�  � {�$ false��. ���  �@J�Opacity$
 0.23Q�P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$ Arrow���� 8    " ��.���  � ��$ 0q���  � ��$ 25����  � ��$ 25����  � y�$ Hidden=���  � ��   $ WindowClose=� 22��  � ��# �  ��  � �� �� " �� ���� '        "  .���  � ��$ 23����  � ��$ 23��.R�� .+��� $ overlay��#��z��$ .1Q�$ 5��$ 5��$y�Hidden=�  #��z��#��z��$
}�True��#��z��# z #��z��$|�False��#��z��# z  �� $ GeometryEllipse��$ RenderedGeometry��� $ GeometryRectangle��
������ $|�False��$ False�� �� $
  True��! �� *	IsFocused+$ InputBoxField��.a���  � y�$ Visible=��� $
  True��! �� *	IsFocused+$ ButtonClear��.a���  � y�$ Visible=�P�  �@J�IsMouseOver$
 true��. ��� $ overlay�� � y�$ Visible=�P�  � {�$ false��. ���  �@J�Opacity$
 0.23Q�P�  �@J�IsMouseOver$
 True��. ���  �@�Cursor$ Arrow���� 8    " ��.���  �@�FocusVisualStyle8  ��  � �� ��  �� "" �$ (TextElement.Foreground)���  �@=�ErrorTemplate8  ��  � �� �� " �� ���� 	Click
 .��U� $# InteractionEllipse��$$ (FrameworkElement.Width)�.\�  $% 0Q�$& 0��  $% 48Q�$& 0:0:0.3��U� $# InteractionEllipse��$$ (FrameworkElement.Height)�.\�  $% 0Q�$& 0��  $% 48Q�$& 0:0:0.3��U� $# InteractionEllipse��$U$ O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�.\�  $% 0Q�$& 0��  $	% -24Q�$& 0:0:0.3��U� $# InteractionEllipse��$U$ O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�.\�  $% 0Q�$& 0��  $	% -24Q�$& 0:0:0.3��U� $# InteractionEllipse��$$ (UIElement.Opacity)�.\�  $	% 0.3Q�$& 0��  $% 0Q�$& 0:0:0.3��.R�� $' templateRoot��
������ $
 True��( �� $
��Auto ��� $��* �.+�(� #��z��$��LeftToRight=�����  �� *TemplatedParent+$' !(wpf:CheckBoxAssist.CheckBoxSize)�����  �� *TemplatedParent+$' !(wpf:CheckBoxAssist.CheckBoxSize)�.���� $��24��$��24��.+�F� $) Graphic���������R � ��eR  � ���ʡE@ � ��-  � ��-  @, ���-  �,��eR  8Q  �$  �$ �J]���R 8Q��]w �,  �$  �$ �J]��]w @, ��]w �  �f � ��R � ���R @, ���R �,��eR  �,��eR  @, ���R @, 	#���  A� $* InteractionEllipse��$+ 12��$, 12��$��0��$��0��#��z��$ False��$ 0Q�$- 0.5,0.5&�z�V� .~��� �� �� T� �� $. contentPresenter��$��1��#��z��#��z��#��z��$|�False��$
��True��# z  ^� / �� 0 ��  �� *Self+$ 	IsPressed�1 true�� 0 ��  �� *Self+$# (wpf:RippleAssist.IsDisabled)�	1 false2 �� 8�� P�  � ��$
 true��. ��� 8   �@�FocusVisualStyle��  � ��$ 4,0,0,3q�P�  � ��$
 true��P�  �@d�	IsChecked$
 trueY�. ��� $ Graphic�� � ��� ��@�  ���eR �l� � 7l `l� �@� �(� �`�8`.I ���R�.c ���R � ��eR  � ���ʡE@ � ��-  � ��-  @, ���-  �,��eR  8Q  �$  �$ �J]���R 8Q��]w �,  �$  �$ �J]��]w @, ��]w �  �f � ��R � 	�� $ Graphic�� ��  �� *TemplatedParent+$ 
Background� � ��P�  � {�$ false��. ��� $ Graphic��# �   � ����  �@J�Opacity$
 0.56Q�P�  Z�  �@d�	IsChecked. ��� $ Graphic�� � ��� ��@�d  �� �@�d  � �@o@ � �@o@ �� ���R � ��eR  � ���ʡE@ � ��-  � ��-  @, ���-  �,��eR  8Q  �$  �$ �J]���R 8Q��]w �,  �$  �$ �J]��]w @, ��]w �  �f � ��R � 	�� $ Graphic�� ��  �� *TemplatedParent+$ 
Background� � ��P�  �@=�HasError$
 true��. ��� $ Graphic��# �   � ���� $ contentPresenter��# �   � ��P�  �@J�IsMouseOver$
 True��. ��� $ Graphic�� �@J�Opacity$
 0.75Q�