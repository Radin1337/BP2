   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5      3clr-namespace:Client.ViewModelClient.ViewModel  66       Client.View.AutomobilView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Client.View     5      4	viewmodelclr-namespace:Client.ViewModel     66   .��5	      � 
����ح�$��	100,0,0,0q�6"     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $	��440 �6   �� 5      $
��Auto �6   .+�5   
   �� $��13(�6   
���   �$��Center=�64   
�������$��1��6o   $��	0,210,0,0q�6|   ��6�   �� *
Automobili+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *	Izabran+ �� View 5      �� 5       �� AllowsColumnReorder .  .P�5      �� $��SASIJA��6%    �� Width$ 70��65    �� DisplayMemberBinding 6@   �� *SASIJA+ �� Mode$ OneTime=��� 5      $��Marka��6%   $	 100��64    6@   �� *Marka+$ OneTime=��� 5      $��Broj SK��6%   $	 100��66    6B   �� *BrSK+$ OneTime=��� 5      $��Datum SK��6%   $	 140��67    6C   �� *DatSK+ �� StringFormat$ 
dd.MM.yyyy��$ OneTime=��� 5      $��Tip automobila��6%   $	 140��6=    6I   �� *TipMot+$ OneTime=��� 5      $��
ID servisa��6%   $	 140��69    6E   �� *	ServisIDS+$ OneTime=�5      5      	� 5   
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
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��Marka: ��6G   $��1��6Y   $��30��6f   $
��Left=�6r   $	��Top=�6�   $��	10,40,0,0q�6�   �� 5'   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��	Broj SK: ��6G   $��1��6[   $��30��6h   $
��Left=�6t   $	��Top=�6�   $��	12,70,0,0q�6�   �� 5(   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��
Datum SK: ��6G   $��1��6\   $��30��6i   $
��Left=�6u   $	��Top=�6�   $��
10,100,0,0q�6�   �� 5)   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��Tip automobila: ��6G   $��1��6b   $��30��6o   $
��Left=�6{   $	��Top=�6�   $��
10,130,0,0q�6�   �� 5*   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��ID servisa: ��6G   $��1��6^   $��30��6k   $
��Left=�6w   $	��Top=�6�   $��
10,160,0,0q�6�   �� 5-   
   $��13(�6   $��1��6    $��30��6-   $��Center=�69   $
��Left=�6[   $	��Top=�6v   $	��170��5.   ?   $��
125,10,0,0q�6K   ��6   �� *Izabran.SASIJA+$ TwoWay=�6K   �� 5/   
   $��13(�6   $��1��6    $��30��6-   $��Center=�69   $
��Left=�6[   $	��Top=�6v   $	��170��50   >   $��
125,40,0,0q�6J   ��6   �� *Izabran.Marka+$ TwoWay=�6J   �� 51   
   $��13(�6   $��1��6    $��30��6-   $��Center=�69   $
��Left=�6[   $	��Top=�6v   $	��170��52   =   $��
125,70,0,0q�6I   ��6   �� *Izabran.BrSK+$ TwoWay=�6I   (  "System.Windows.Controls.DatePicker  53   
   $��13(�6   $��1��6#   $��30��60   $��Center=�6<   $
��Left=�6^   $	��Top=�6y   $	��170��54   W   $��125,100,0,0q�6c      Text 6   �� *Izabran.DatSK+$ 	dd.MM.yyy��$ TwoWay=�6c   �� 55   
   $��13(�6   $��1��6!   $��30��6.   $��Center=�6:   $
��Left=�6\   $	��Top=�6w   $	��170��57   G   $��125,130,0,0q�6S   ��56      �� *	tipAuto+ 57      �� *Izabran.TipMot+$ TwoWay=�6S   �� 58   
   $��13(�6   $��1��6!   $��30��6.   $��Center=�6:   $
��Left=�6\   $	��Top=�6w   $	��170��5:   J   $��125,160,0,0q�6V   ��59      �� *ids+$ PropertyChanged=� 5:      �� *Izabran.ServisIDS+$ TwoWay=�6V   5;      5<      