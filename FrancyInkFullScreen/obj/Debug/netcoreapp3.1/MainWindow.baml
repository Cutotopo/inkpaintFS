   M S B A M L   `   `   `  ����N  JFrancyInkFullScreen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FrancyInkFullScreenFrancyInkFullScreen  5   	   $    FrancyInkFullScreen.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:FrancyInkFullScreen     5   	     � WindowState$  	Maximized=�5   	    � WindowStyle$
 None=�5	   	    � Title$ FrancyInk FSBETA (1080p)��5
   	   $
��1080��6*   $
��1920��68   .��5      �  � RowDefinitions 5   
   �� 5      $
��1080 �6   .+�5   
   �� $
��Left=�6   $
��1080��6+   $
��1920��69   $	��Top=�6F   $��/rows1920.png��6^   ��5   
   �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ Hidden=�6/    �� Triggers 5      �� 5       �� Binding 6"   �� 	 �� ElementName$	 ControlloRighe��
 �� Path$
 	IsChecked� �� Value True6a   .a�5      ��  � y�$ Visible=�67   5      5      5      �� 5   
   $
��Left=�6   $
��1080��6+   $	��Top=�69   $
��1920��6Q   $��/squares1920.png��6^   ��5      �� 5      " ��6   .�5      ��  � y�$ Hidden=�63    5      �� 5        6&   �� $	 ControlloGriglia��$
 	IsChecked� True6g   .a�5!      ��  � y�$ Visible=�6;   5"      5$      5&      +  %System.Windows.Controls.Ribbon.Ribbon  5'   
   -   5          Name$ Ribbon��5'       �� SelectedIndex$ 0��6"   $��0,-20,0,742q�64      ApplicationMenu 5(      :  4System.Windows.Controls.Ribbon.RibbonApplicationMenu  5)      5  /System.Windows.Controls.Ribbon.RibbonMenuButton   KeyTip$ F��6(      Label$
 File��63   .@�5*      >  8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   5        $
��Apri��5*   0   6>   C  =System.Windows.Controls.Ribbon.RibbonApplicationSplitMenuItem  5+      -   5        $��Salva��5+   5   .@�5,        -   5        $��File FrancyInk��5,   4   6L     5-      -   5        $��File FrancyInk Low-Res��5-   4   6T   5.        5/      -   5        $��Salva una copia��5/   5   .@�50        -   5        $��File FrancyInk��50   4   6L     51      -   5        $��File FrancyInk Low-Res��51   4   6T   52        53      -	   5        $��Evidenziatore��53   5   .@�54        -
   5        $��	Disattiva��54   4   6G     55      -   5        $#��Attiva con il colore corrente��55   4   6[     56      -   5        $��Rosso��56   4   6C     57      -   5        $��Verde��57   4   6C     58      -   5        $��Giallo��58   4   6D   59        5:      $��Input��60   .@�5;        $��Penna e mouse��64   ${�False��6K     5<      $��
Solo penna��64   ${�False��6H     5=      $��
Solo mouse��64   $
{�True��6H   5>        5?      -   5        $��Sfondo��5?   5   .@�5@        -   5          Name$ PercorsoFileMenu��5@   i   $��Nessuna immagine caricata��64   ${�False��6W   6i     5A      ${�False��64   $��10��6F     5B      -   5        $��Seleziona immagine��5B   4   6P     5C      -   5        $��Rimuovi immagine��5C   4   6N   5D      4  .System.Windows.Controls.Ribbon.RibbonSeparator  5E        5F      -   5        $��Stampa��5F   5   .@�5G        -   5        $��Stampa��5G   4   6D     5H      -   5        $��Stampa rapida��5H   4   6K     5I      $��Anteprima di stampa��64   ${�False��6Q   5J        5K        5L      -   5        $��Elimina tavola��5L   0   6H     5M        5N      -   5        $��Chiudi��5N   0   6@   5O      .@�5Q      .  (System.Windows.Controls.Ribbon.RibbonTab  $��Penna��6   .@�5R      0  *System.Windows.Controls.Ribbon.RibbonGroup  $��Spessore del tratto��6   .@�5S      1	  +System.Windows.Controls.Ribbon.RibbonButton	  -   5         	  Label$	 1,0��5S   #   6/   	  5T      -   5        $	 1,5��5T   #   6/   	  5U      -   5        $	 2,0��5U   #   6/   	  5V      -   5        $	 2,5��5V   #   6/   	  5W      -   5        $	 3,0��5W   #   6/   	  5X      -   5        $	 3,5��5X   #   6/   	  5Y      -   5        $	 4,0��5Y   #   6/   	  5Z      -   5        $	 4,5��5Z   #   6/   	  5[      -    5        $	 5,0��5[   #   6/   5\        5]      $��Colore del tratto��6   .@�5^      	  -!   5        $
 Nero��5^   #   
���   �
�������6V   	  5_      -"   5        $ Rosso��5_   #   
���  ��
�������6V   	  5`      -#   5        $ Verde��5`   #   
��� � �
�������6X   	  5a      -$   5        $	 Blu��5a   #   
����  �
�������6S   	  5b      -%   5        $ Giallo��5b   #   
��� ���6G   5c        5d      $��Opzioni��6   .@�5e      	  -&   5         	 Name$ TogglePannelloRapido��5e   [   $ Apri pannello rapido��6#   6y   5f      5g        5h      $��	Strumenti��6   .@�5i        $��Modifica��6   .@�5j      	  -'   5        $ Gomma��5j   #   61   5k        5l      $��Colore��6   .@�5m      3
  -System.Windows.Controls.Ribbon.RibbonCheckBox
  -(   5         
  Label$ Evidenziatore��5m   %   6O   5n        5o      $��Disegno��6   .@�5p      	  -)   5        $ Svuota tavola��5p   #   69   5q      5r        5s      $��Visualizzazione��6   .@�5t        $��Risoluzione��6   .@�5u      �� $��	1920x1080��6   ${�False��6/   �� 5v      $��Applica��6   ${�False��6/   �� 5w      -*   5        $	��(i)��5w      6+   5x        5y      $
��Zoom��6   .@�5z      	  -+   5        $ Aumenta��5z   #   63   	  5{      -,   5        $ Riduci��5{   #   62   5|        5}      $��Guide��6   .@�5~      
  --   5         
 Name$ ControlloGriglia��5~   7   $ 	Quadretti��6%   67   
  5      -.   5        $ ControlloRighe��5   3   $ Righe��6%   63   5�      5�        5�      $��Sfondo��6   .@�5�        $��Immagine��6   .@�5�      	  -/   5        $ ApriImmagineButton��5�   9   $ Apri immagine��6#   6U   	  5�      -0   5        $ Rimuovi immagine��5�   #   6<   5�        5�      $��Percorso��6   .@�5�      �� $ ��Percorso immagine corrente��6   �� 5�      -1   5         ��Name$ PercorsoFile��5�   @   $��   Nessun file aperto   ��6   ${�False��6V   5�      5�        5�      $��
Cronologia��6   .@�5�        $��Evento��6   .@�5�      �� -2   5        $ 
EventoTipo��5�   A   $��Nessun evento da mostrare��6   ${�False��6U   $	��256��6g   �� 5�      -3   5        $ EventoDurata��5�   F   $�� ��6   $	��256��6(   ${�False��64   6F   5�        5�      $��Ultimo evento��6   .@�5�      �� -4   5        $ UltimoEventoTipo��5�   [   $��Nessun evento recente��6   $	��256��6=   ${�False��6I   6[   �� 5�      -5   5        $ UltimoEventoOra��5�   N   $��--:--:--��6   $	��256��60   ${�False��6<   6N   5�      5�      5�      �� 5�   
   -6   5         ��Name$ ImageControl��5�   +   $
��Left=�6   $	��Top=�6A   $
��1088��6Y   $
��1926��6g   $��	0,115,0,0q�6t   �� 5�   
   -7   5         ��Name$ 	FrancyINK��5�   @   $��	0,115,0,0q�6    �� 
Background
 ���� 6S   �� 5�   
   $
��File��6   
������� J� IsHitTestVisible$ False��62   $��4,1,1888,1054q�6K   5�      5�      