   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5      3clr-namespace:Client.ViewModelClient.ViewModel  66       Client.View.MajstorView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Client.View     5      4	viewmodelclr-namespace:Client.ViewModel     66   .��5	      � 
����ح�$��	100,0,0,0q�6"     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $	��440 �6   �� 5      $
��Auto �6   .+�5   
   �� $��13(�6   
���   �$��Center=�64   
�������$��1��6o   $��	0,210,0,0q�6|   ��6�   �� *
Majstori+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *	Izabran+ �� View 5      �� 5       �� AllowsColumnReorder .  .P�5      �� $
��JMBG��6%    �� Width$	 160��63    �� DisplayMemberBinding 6?   �� *JMBG+ �� Mode$ OneTime=��� 5      $	��Ime��6%   $	 150��62    6>   �� *Ime+$ OneTime=��� 5      $��Prezime��6%   $	 150��66    6B   �� *	Prezime+$ OneTime=��� 5      $��
ID Servisa��6%   $ 70��69    6D   �� *	ServisIDS+$ OneTime=��� 5      $��Tip servisera��6%   $	 160��6<    6H   �� *	TipServ+$ OneTime=�5      5      	� 5   
   $��Italic$�6M   $��13(�6`   $��DemiBold"�6n    	� 	GroupName$ 	operacija��6�   $	��100��6�   $��30��6�   $��560,10,40,401q�6�   $��1��6�   $��Center=�6�   	 d� 	IsChecked	 6   �� *RadioIzmeni+$ OneWayToSource=�.��6�   Izmeni5      	� 5   
   -   5        $��radioServisDodaj��5   �   $��Italic$�6L   $��13(�6_   $��DemiBold"�6m   $ 	operacija��6�   $	��100��6�   $��30��6�   $��560,40,40,371q�6�   $��1��6�   $��Center=�6�   	 6   �� *
RadioDodaj+$ OneWayToSource=�.��6  Dodaj5      	� 5    
   -   5        $��radioServisObrisi��5    �   $��Italic$�6M   $��13(�6`   $��DemiBold"�6n   $ 	operacija��6�   $	��100��6�   $��30��6�   $��560,70,40,341q�6�   $��1��6�   $��Center=�6�   	 6   �� *RadioObrisi+$ OneWayToSource=�.��6  Obrisi5"      �� 5#   
   -   5        $��btnServisOp��5#   N   $��13(�6   $��DemiBold"�6   
���2͚�$��1��6a   $��Izvrsi operaciju��6n   $��560,101,20,300q�6�   ��6�   �� *KomandaIzvrsi+�� 5$   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��JMBG: ��6G   $��1��6X   $��30��6e   $
��Left=�6q   $	��Top=�6�   $��	10,10,0,0q�6�   �� 5%   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��Ime: ��6G   $��1��6W   $��30��6d   $
��Left=�6p   $	��Top=�6�   $��	10,40,0,0q�6�   �� 5&   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��	Prezime: ��6G   $��1��6[   $��30��6h   $
��Left=�6t   $	��Top=�6�   $��	12,70,0,0q�6�   �� 5'   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��ID Servisa: ��6G   $��1��6^   $��30��6k   $
��Left=�6w   $	��Top=�6�   $��
10,100,0,0q�6�   �� 5(   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��Tip servisera: ��6G   $��1��6a   $��30��6n   $
��Left=�6z   $	��Top=�6�   $��
10,130,0,0q�6�   �� 5*   
   $��13(�6   $��1��6    $��30��6-   $��Center=�69   $
��Left=�6[   $	��Top=�6v   $	��170��5+   =   $��
105,10,0,0q�6I   ��6   �� *Izabran.JMBG+$ TwoWay=�6I   �� 5,   
   $��13(�6   $��1��6    $��30��6-   $��Center=�69   $
��Left=�6[   $	��Top=�6v   $	��170��5-   <   $��
105,40,0,0q�6H   ��6   �� *Izabran.Ime+$ TwoWay=�6H   �� 5.   
   $��13(�6   $��1��6    $��30��6-   $��Center=�69   $
��Left=�6[   $	��Top=�6v   $	��170��5/   @   $��
105,70,0,0q�6L   ��6   �� *Izabran.Prezime+$ TwoWay=�6L   �� 50   
   $��13(�6   $��1��6!   $��30��6.   $��Center=�6:   $
��Left=�6\   $	��Top=�6w   $	��170��52   J   $��105,100,0,0q�6V   ��51      �� *ids+ 52      �� *Izabran.ServisIDS+$ TwoWay=�6V   �� 53   
   
�������
 �� 
IsReadOnly
 . $��13(�6;   $��1��6I   $��30��6V   $��Center=�6b   $
��Left=�6�   $	��Top=�6�   $	��170��54   @   $��105,130,0,0q�6L   ��6   �� *Izabran.TipServ+$ TwoWay=�6L   55      56      