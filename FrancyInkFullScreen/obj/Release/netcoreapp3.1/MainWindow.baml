   M S B A M L   `   `   `  ���� N  JFrancyInkFullScreen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FrancyInkFullScreenFrancyInkFullScreen  $    FrancyInkFullScreen.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:FrancyInkFullScreen       � WindowState$  	Maximized=� � WindowStyle$
 None=� � Title$ FrancyInk FSBETA (1080p)��$
��1080��$
��1920��.���  � RowDefinitions �� $
��1080 �.+��� $
��Left=�$
��1080��$
��1920��$	��Top=�$��/rows1920.png������  �� 
TargetType" ��.���  �� Property � y� �� Value$ Hidden=� �� Triggers ��  �� Binding �� 	 �� ElementName$	 ControlloRighe��
 �� Path$
 	IsChecked� �� Value True.a���  � y�$ Visible=��� $
��Left=�$
��1080��$	��Top=�$
��1920��$��/squares1920.png������ " ��.���  � y�$ Hidden=� ��  �� $	 ControlloGriglia��$
 	IsChecked� True.a���  � y�$ Visible=�+  %System.Windows.Controls.Ribbon.Ribbon  -     Name$ Ribbon�� �� SelectedIndex$ 0��$��0,-20,0,742q�   ApplicationMenu :  4System.Windows.Controls.Ribbon.RibbonApplicationMenu  5  /System.Windows.Controls.Ribbon.RibbonMenuButton   KeyTip$ F��   Label$
 File��.@�>  8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   $
��Apri��C  =System.Windows.Controls.Ribbon.RibbonApplicationSplitMenuItem  -   $��Salva��.@�  -   $��File FrancyInk��  -   $��File FrancyInk Low-Res��  -   $��Salva una copia��.@�  -   $��File FrancyInk��  -   $��File FrancyInk Low-Res��  -	   $��Evidenziatore��.@�  -
   $��	Disattiva��  -   $#��Attiva con il colore corrente��  -   $��Rosso��  -   $��Verde��  -   $��Giallo��  $��Input��.@�  $��Penna e mouse��${�False��  $��
Solo penna��${�False��  $��
Solo mouse��$
{�True��  -   $��Sfondo��.@�  -     Name$ PercorsoFileMenu��$��Nessuna immagine caricata��${�False��  ${�False��$��10��  -   $��Seleziona immagine��  -   $��Rimuovi immagine��4  .System.Windows.Controls.Ribbon.RibbonSeparator    -   $��Stampa��.@�  -   $��Stampa��  -   $��Stampa rapida��  $��Anteprima di stampa��${�False��    -   $��Elimina tavola��    -   $��Chiudi��.@�.  (System.Windows.Controls.Ribbon.RibbonTab  $��Penna��.@�0  *System.Windows.Controls.Ribbon.RibbonGroup  $��Spessore del tratto��.@�1	  +System.Windows.Controls.Ribbon.RibbonButton	  -    	  Label$	 1,0��	  -   $	 1,5��	  -   $	 2,0��	  -   $	 2,5��	  -   $	 3,0��	  -   $	 3,5��	  -   $	 4,0��	  -   $	 4,5��	  -    $	 5,0��  $��Colore del tratto��.@�	  -!   $
 Nero��
���   �
�������	  -"   $ Rosso��
���  ��
�������	  -#   $ Verde��
��� � �
�������	  -$   $	 Blu��
����  �
�������	  -%   $ Giallo��
��� ���  $��Opzioni��.@�	  -&    	 Name$ TogglePannelloRapido��$ Apri pannello rapido��  $��	Strumenti��.@�  $��Modifica��.@�	  -'   $ Gomma��  $��Colore��.@�3
  -System.Windows.Controls.Ribbon.RibbonCheckBox
  -(    
  Label$ Evidenziatore��  $��Disegno��.@�	  -)   $ Svuota tavola��  $��Visualizzazione��.@�  $��Risoluzione��.@��� $��	1920x1080��${�False���� $��Applica��${�False���� -*   $	��(i)��  $
��Zoom��.@�	  -+   $ Aumenta��	  -,   $ Riduci��  $��Guide��.@�
  --    
 Name$ ControlloGriglia��$ 	Quadretti��
  -.   $ ControlloRighe��$ Righe��  $��Sfondo��.@�  $��Immagine��.@�	  -/   $ ApriImmagineButton��$ Apri immagine��	  -0   $ Rimuovi immagine��  $��Percorso��.@��� $ ��Percorso immagine corrente���� -1    ��Name$ PercorsoFile��$��   Nessun file aperto   ��${�False��  $��
Cronologia��.@�  $��Evento��.@��� -2   $ 
EventoTipo��$��Nessun evento da mostrare��${�False��$	��256���� -3   $ EventoDurata��$�� ��$	��256��${�False��  $��Ultimo evento��.@��� -4   $ UltimoEventoTipo��$��Nessun evento recente��$	��256��${�False���� -5   $ UltimoEventoOra��$��--:--:--��$	��256��${�False���� -6    ��Name$ ImageControl��$
��Left=�$	��Top=�$
��1088��$
��1926��$��	0,115,0,0q��� -7    ��Name$ 	FrancyINK��$��	0,115,0,0q� �� 
Background
 ���� �� $
��File��
������� J� IsHitTestVisible$ False��$��4,1,1888,1054q�