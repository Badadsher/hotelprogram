   M S B A M L   `   `   `  ����@  <Teatr, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Teatr.ViewsTeatr.Views  5          Teatr.Views.guestPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Teatr.Views     5        N� Title$  	guestPage��5	       � 	Resources 5
         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%J  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E    . $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5        � ��8  6,   �� 5!       � ��# � ��6+   �� 5"       � ��$ 1q�60   �� 5#       � ��$ Center=�6;   �� 5$       � ��$ Center=�69   �� 5%       � ��$ 1q�6(   �� 5&       � �� 5'      �� 5(      " ��6&   .R�5)      �� $	 border��6!   #��z��61   $
 20��6[   #��z��6m   #��z��6�    . ._�5*      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5+       5,      P� 5-       �@��IsDefaulted . . �5.   "   �� $ border��6@   # � ��6T    � ��5/      P� 50       �@J�IsMouseOver . . �51   "   �� $ border��6?   8   � ��6S   �� 52   "   $ border��6@   8   � ��6T   53      P� 54       � �� . . �55   "   �� $ border��6?   8   � ��6S   �� 56   "   $ border��6@   8   � ��6T   57      P� 58       � {� .  . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   �� 5;   "   $ contentPresenter��6K   8 	  � ��6i   5<      5>      5@      5A      5B      .��5D      � ��5E   
   �� 5F       �� ImageSource$ /Views/BACK.png��6   .+�5H   
   �� $��Center=�6   $��63��61   
���   �$	��Top=�6L   $	��800��6d   ���	#FF0A2B4B$��0,-1,0,0q�6�   �� 5I   
   $��Center=�6   $��63��61   
���   �$	��Top=�6L   $	��800��6d   ���	#FF0A2B4B$��	0,387,0,0q�6�   �� 5J   
   $
��Left=�6   $��30��6/   $��713,404,0,0q�6;   $	��Top=�6P   $��29��6h   ��5K      �� 5L      $! /Views/instagram-icon 2.png��6   5N      �� 5O   
   $
��Left=�6   $��30��6/   $��747,403,0,0q�6;   $	��Top=�6P   $��29��6h   ��5P      �� 5Q      $  /Views/whatsapp-icon 2.png��6   5S      &   System.Windows.Controls.DataGrid  5T   
   -   5          Name$ 	HotelGrid��5T      $��313,86,10,136q�6Q      AutoGenerateColumns .     Columns 5U      0  *System.Windows.Controls.DataGridTextColumn  5V      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *id+  5W      $ Название��6%   $ * 67    6A   �� *	hotelname+  5X      $ 
Класс��6%   $ * 64    6>   �� *class+  5Y      $ Срок��6%   $ * 63    6=   �� *term+  5Z      $ Статус��6%   $ * 65    6?   �� *status+5\      �� 5^   
   $��EDEN HOTELS��6   $��Center=�6&   $��0,10,0,0q�6C   $	��Top=�6U   $	��220��6m   $��Center=�6y   $��Bahnschrift Condensed)�6�   
�������$��40(�6�   �� 5_   
   $��©AliEnterteiment��6   $
��Left=�6+   $��290,401,0,0q�6F   $	��Top=�6[   $	��262��6s   $��Center=�6   $��Edwardian Script ITC)�6�   
�������$��20(�6�   �� 5`   
   -   5         ��Name$
 rend��5`   8   #��� 
 6   $ ��Забронировать��6H   $
��Left=�6`   $��
80,189,0,0q�6{   $	��Top=�6�   $��36��6�   $	��129��6�   ���	#FF65FF00$��Bahnschrift Condensed)�6�   $��18(�6�   6  �� 5a   
   -   5        $ refresh��5a   8   #��� 
 6   $��Обновить��6K   $
��Left=�6^   $��
80,251,0,0q�6y   $	��Top=�6�   $��36��6�   $	��129��6�   ���	#FFFF8000$��Bahnschrift Condensed)�6�   $��18(�6�   6  5b      5c      