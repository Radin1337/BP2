   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5      3clr-namespace:Client.ViewModelClient.ViewModel  66        Client.View.PopravljenView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Client.View     5      4	viewmodelclr-namespace:Client.ViewModel     66   .��5	      � 
����ح�$��	100,0,0,0q�6"     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $	��440 �6   �� 5      $
��Auto �6   .+�5   
   �� $��13(�6   
���   �$��Center=�64   
�������$��1��6o   $��	0,210,0,0q�6|   ��6�   �� *Popravljeni+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *	Izabran+ �� View 5      �� 5       �� AllowsColumnReorder .  .P�5      �� $��SASIJA��6%    �� Width$ 70��65    �� DisplayMemberBinding 6@   �� * PokvarenPregledAutomobilSASIJA+ �� Mode$ OneTime=��� 5      $��DijagnosticarJMBG��6%   $	 165��6@    6L   �� *" PokvarenPregledDijagnosticarJMBG+$ OneTime=��� 5      $��PDeoID��6%   $ 70��65    6@   �� *PokvarenDeoDEOID+$ OneTime=��� 5      $��MajstorJMBG��6%   $	 165��6:    6F   �� *MajstorZaMajstorJMBG+$ OneTime=��� 5      $��MDeoID��6%   $ 70��65    6@   �� *MajstorZaDeoDEOID+$ OneTime=��� 5      $��Datum popravke��6%   $	 165��6=    6I   �� *DatPop+ �� StringFormat$ 
dd.MM.yyyy��$ OneTime=�5      5      	� 5   
   $��Italic$�6M   $��13(�6`   $��DemiBold"�6n   	 	� 	GroupName$	 	operacija��6�   $	��100��6�   $��30��6�   $��560,10,40,401q�6�   $��1��6�   $��Center=�6�   
 d� 	IsChecked
 6   �� *RadioIzmeni+$ OneWayToSource=�.��6�   Izmeni5      	� 5   
   -   5        $��radioServisDodaj��5   �   $��Italic$�6L   $��13(�6_   $��DemiBold"�6m   $	 	operacija��6�   $	��100��6�   $��30��6�   $��560,40,40,371q�6�   $��1��6�   $��Center=�6�   
 6   �� *
RadioDodaj+$ OneWayToSource=�.��6  Dodaj5       	� 5!   
   -   5        $��radioServisObrisi��5!   �   $��Italic$�6M   $��13(�6`   $��DemiBold"�6n   $	 	operacija��6�   $	��100��6�   $��30��6�   $��560,70,40,341q�6�   $��1��6�   $��Center=�6�   
 6   �� *RadioObrisi+$ OneWayToSource=�.��6  Obrisi5#      �� 5$   
   -   5        $��btnServisOp��5$   N   $��13(�6   $��DemiBold"�6   
���2͚�$��1��6a   $��Izvrsi operaciju��6n   $��560,101,20,300q�6�   ��6�   �� *KomandaIzvrsi+�� 5%   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��SASIJA: ��6G   $��1��6Z   $��30��6g   $
��Left=�6s   $	��Top=�6�   $��	10,10,0,0q�6�   �� 5&   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��DijagnosticarJMBG: ��6G   $��1��6e   $��30��6r   $
��Left=�6~   $	��Top=�6�   $��	10,40,0,0q�6�   �� 5'   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��PDeoID: ��6G   $��1��6Z   $��30��6g   $
��Left=�6s   $	��Top=�6�   $��	12,70,0,0q�6�   �� 5(   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��MajstorJMBG: ��6G   $��1��6_   $��30��6l   $
��Left=�6x   $	��Top=�6�   $��
10,100,0,0q�6�   �� 5)   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��MDeoID: ��6G   $��1��6Z   $��30��6g   $
��Left=�6s   $	��Top=�6�   $��
10,130,0,0q�6�   �� 5*   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��Datum popravke: ��6G   $��1��6b   $��30��6o   $
��Left=�6{   $	��Top=�6�   $��
10,160,0,0q�6�   �� 5,   
   $��13(�6   $��1��6!   $��30��6.   $��Center=�6:   $
��Left=�6\   $	��Top=�6w   $	��170��5.   _   $��
135,10,0,0q�6k   ��5-      �� *Sasije+$ PropertyChanged=� 5.      �� *(&Izabran.PokvarenPregledAutomobilSASIJA+$ TwoWay=�6k   �� 5/   
   $��13(�6   $��1��6!   $��30��6.   $��Center=�6:   $
��Left=�6\   $	��Top=�6w   $	��170��51   a   $��
135,40,0,0q�6m   ��50      �� *Dijag+$ PropertyChanged=� 51      �� **(Izabran.PokvarenPregledDijagnosticarJMBG+$ TwoWay=�6m   �� 52   
   $��13(�6   $��1��6!   $��30��6.   $��Center=�6:   $
��Left=�6\   $	��Top=�6w   $	��170��54   Q   $��
135,70,0,0q�6]   ��53      �� *PDeoID+$ PropertyChanged=� 54      �� *Izabran.PokvarenDeoDEOID+$ TwoWay=�6]   �� 55   
   $��13(�6   $��1��6!   $��30��6.   $��Center=�6:   $
��Left=�6\   $	��Top=�6w   $	��170��57   U   $��135,100,0,0q�6a   ��56      �� *
Majstori+$ PropertyChanged=� 57      �� *Izabran.MajstorZaMajstorJMBG+$ TwoWay=�6a   �� 58   
   $��13(�6   $��1��6!   $��30��6.   $��Center=�6:   $
��Left=�6\   $	��Top=�6w   $	��170��5:   R   $��135,130,0,0q�6^   ��59      �� *MDeoID+$ PropertyChanged=� 5:      �� *Izabran.MajstorZaDeoDEOID+$ TwoWay=�6^   (  "System.Windows.Controls.DatePicker  5;   
      IsTodayHighlighted . $��13(�6/   $��1��6=   $��30��6J   $��Center=�6V   $
��Left=�6x   $	��Top=�6�   $	��170��5<   Z   $��135,160,0,0q�6f      Text 6   �� *Izabran.DatPop+$ 
dd.MM.yyyy��$ TwoWay=�6f   5=      5>      