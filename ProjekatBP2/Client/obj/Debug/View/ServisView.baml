   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5      3clr-namespace:Client.ViewModelClient.ViewModel  66       Client.View.ServisView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Client.View     5      4	viewmodelclr-namespace:Client.ViewModel     66   .��5	      � 
����ح�$��	100,0,0,0q�6"     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $	��440 �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��
ServisGrid��5   o   $��13(�6   
���   �$��Center=�64   
�������$��1��6�   $��	0,210,0,0q�6�   ��6�   �� *	Servisi+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *IzabranServis+ �� View 5      �� 5       �� AllowsColumnReorder .  -   5        	grdServis��.P�5      �� $��
ID servisa��6%    �� Width$ 70��69    �� DisplayMemberBinding 6D   �� *IDS+ �� Mode$ OneTime=��� 5      $��Naziv servisa��6%   $	 150��6<    6H   �� *NazivS+$ OneTime=��� 5      $��Telefon��6%   $	 150��66    6B   �� *	Telefon+$ OneTime=��� 5      $��Adresa��6%   $	 325��65    6A   �� *Adresa+$ OneTime=�5      5      �� 5   
   -   5        $��lblServisIDS��5   G   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��ID Servisa: ��6[   $��1��6r   $��30��6   $
��Left=�6�   $	��Top=�6�   $��	10,10,0,0q�6�   �� 5   
   -   5        $��txtServisIDS��5   I   
������� �� 
IsReadOnly . $��13(�6;   $��1��6]   $��30��6j   $��Center=�6v   $
��Left=�6�   $	��Top=�6�   $	��170��5   B   $��
105,10,0,0q�6N   ��6   �� *IzabranServis.IDS+$ TwoWay=�6N   �� 5   
   -   5        $��lblServisNaziv��5   G   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��Naziv Servisa: ��6]   $��1��6w   $��30��6�   $
��Left=�6�   $	��Top=�6�   $��	10,40,0,0q�6�   �� 5   
   -   5        $��txtServisNaziv��5       $��13(�6   $��1��66   $��30��6C   $��Center=�6O   $
��Left=�6q   $	��Top=�6�   $	��170��5   E   $��
105,40,0,0q�6Q   ��6   �� *IzabranServis.NazivS+$ TwoWay=�6Q   �� 5   
   -   5        $��lblServisTelefon��5   G   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��	Telefon: ��6_   $��1��6s   $��30��6�   $
��Left=�6�   $	��Top=�6�   $��
10,100,0,0q�6�   �� 5    
   -   5        $��txtServisTelefon��5        $��13(�6   $��1��68   $��30��6E   $��Center=�6Q   $
��Left=�6s   $	��Top=�6�   $	��170��5!   E   $��
105,70,0,0q�6Q   ��6   �� *IzabranServis.Adresa+$ TwoWay=�6Q   �� 5"   
   -	   5        $��lblServisAdresa��5"   G   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��Adresa: ��6^   $��1��6q   $��30��6~   $
��Left=�6�   $	��Top=�6�   $��	12,70,0,0q�6�   �� 5#   
   -
   5        $��txtServiAdresa��5#       $��13(�6   $��1��66   $��30��6C   $��Center=�6O   $
��Left=�6q   $	��Top=�6�   $	��170��5$   F   $��105,100,0,0q�6R   ��6   �� *IzabranServis.Telefon+$ TwoWay=�6R   	� 5%   
   $��Italic$�6M   $��13(�6`   $��DemiBold"�6n   	 	� 	GroupName$	 	operacija��6�   $	��100��6�   $��30��6�   $��560,10,40,401q�6�   $��1��6�   $��Center=�6�   
 d� 	IsChecked
 6   �� *RadioIzmeni+$ OneWayToSource=�.��6�   Izmeni5'      	� 5(   
   -   5        $��radioServisDodaj��5(   �   $��Italic$�6L   $��13(�6_   $��DemiBold"�6m   $	 	operacija��6�   $	��100��6�   $��30��6�   $��560,40,40,371q�6�   $��1��6�   $��Center=�6�   
 6   �� *
RadioDodaj+$ OneWayToSource=�.��6  Dodaj5*      	� 5+   
   -   5        $��radioServisObrisi��5+   �   $��Italic$�6M   $��13(�6`   $��DemiBold"�6n   $	 	operacija��6�   $	��100��6�   $��30��6�   $��560,70,40,341q�6�   $��1��6�   $��Center=�6�   
 6   �� *RadioObrisi+$ OneWayToSource=�.��6  Obrisi5-      �� 5.   
   -   5        $��btnServisOp��5.   N   $��13(�6   $��DemiBold"�6   
���2͚�$��1��6a   $��Izvrsi operaciju��6n   $��560,101,20,300q�6�   ��6�   �� *KomandaIzvrsi+5/      50      