   M S B A M L   `   `   `  ����N  JFrancyInkFullScreen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FrancyInkFullScreenFrancyInkFullScreen  5   	   %    FrancyInkFullScreen.PrintWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:FrancyInkFullScreen     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ Stampa tavola��5	   	   $	��450��6   $	��800��6,   .��5
      � .+�5   
   �� $��Stampa��6   $��20(�6!   $
��Left=�6/   $��	10,10,0,0q�6J   $	��Top=�6]   �� 5   
   $
��Left=�6   $��	10,52,0,0q�6.   $	��Top=�6A   $	��250��6Y   .@�5      �� $&�� Stampante predefinita di Windows��6    �� 
IsSelected$
 True��6F   5      �� 5   
   $
��Left=�6   $��	10,79,0,0q�6.   $	��Top=�6A   $	��250��6Y   .@�5      �� $��Stampa a colori��6   $
 True��65   �� 5      $��Stampa in scala di grigi��6   5      �� 5   
   $��Tavola di prova��6   $��287,10,220,217q�6,   .��5      �� -   5         ��Name$ 	Anteprima��5   L   $
��Left=�6   $	��283��63   $	��184��6?   6L   5      �� 5   
   $��Operazioni su file��6   $��287,270,220,85q�6/   .��5      �� .+�5      1  +System.Windows.Controls.Ribbon.RibbonButton  -   5           Label$ Salva anteprima su file��5      $	��268��6?   $
��Left=�6K   $��10,0,0,0q�6f   6x     5      -   5        $ Carica anteprima da file��5      $
��Left=�6@   $	��268��6[   $��10,0,0,0q�6g   6y   5      5      �� 5   
   $��Pennello��6   $��287,222,220,150q�6%   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5        $ Spessore��6   ${�False��61   �� 5      -   5        $	��1,5��5      6'   �� 5       -   5        $	��2,0��5       6'   �� 5!      -   5        $	��2,5��5!      6'     5"      $  ��6   ${�False��6)     5#      $ Colore��6   ${�False��6.   �� 5$      -   5        $
��Nero��5$      6(   �� 5%      -   5        $	��Blu��5%      6'   �� 5&      -	   5        $��Verde��5&      6)   5'      5(      �� 5)   
   -
   5        $��Stampa��5)      $
��Left=�6"   $��
10,106,0,0q�6=   $	��Top=�6Q   $	��250��6i   6u   5*      5+      