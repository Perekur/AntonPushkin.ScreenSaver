   M S B A M L   `   `   `  ����L  HСlockScreenSaver, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:СlockScreenSaverСlockScreenSaver  5   	   #    СlockScreenSaver.ScreenSaver   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   1localclr-namespace:СlockScreenSaver     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   -   5          � WindowStyle$
  None=�5   	    � AllowsTransparency . 
���   � � ShowInTaskbar .   � Title$ 
MainWindow��5   	   $	��400��6   $	��600��6)    � 	Resources 5         ClockVisualBrush !� Visual �� ElementName  ReflectOpacityMask �� 
StartPoint �� EndPoint	 � Offset
 � Color��%�   &	        &	 (     !� 5   
    6/   �� $ Clock���� 5   
   $	 0,0&�69   $	 0,1&�6J   .��5      � $		 0.3Q�6   $
 Transparent��6(   � 5      $	 1Q�6   $
 	#44000000��6&   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��0 �6   .+�5"   
      СlockScreenSaver.Clock  -   5          Name$ Clock��5"      $��Center=�6%   $	��100q�6@   
���  ��6M   59      5:      