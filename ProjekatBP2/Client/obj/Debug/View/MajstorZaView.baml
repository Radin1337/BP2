   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5      3clr-namespace:Client.ViewModelClient.ViewModel  66       Client.View.MajstorZaView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Client.View     5      4	viewmodelclr-namespace:Client.ViewModel     66   .��5	      � 
����ح�$��	100,0,0,0q�6"     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $	��440 �6   �� 5      $
��Auto �6   .+�5   
   �� $��13(�6   
���   �$��Center=�64   
�������$��1��6o   $��	0,210,0,0q�6|   ��6�   �� *
MajstorZai+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *	Izabran+ �� View 5      �� 5       �� AllowsColumnReorder .  .P�5      �� $
��JMBG��6%    �� Width$	 350��63    �� DisplayMemberBinding 6?   �� *MajstorJMBG+ �� Mode$ OneTime=��� 5      $	��Deo��6%   $	 350��62    6>   �� *
DeoDEOID+$ OneTime=�5      5      	� 5   
   $��Italic$�6M   $��13(�6`   $��DemiBold"�6n    	� 	GroupName$ 	operacija��6�   $	��100��6�   $��30��6�   $��560,10,40,401q�6�   $��1��6�   $��Center=�6�   	 d� 	IsChecked	 6   �� *RadioIzmeni+$ OneWayToSource=�.��6�   Izmeni5      	� 5   
   -   5        $��radioServisDodaj��5   �   $��Italic$�6L   $��13(�6_   $��DemiBold"�6m   $ 	operacija��6�   $	��100��6�   $��30��6�   $��560,40,40,371q�6�   $��1��6�   $��Center=�6�   	 6   �� *
RadioDodaj+$ OneWayToSource=�.��6  Dodaj5      	� 5   
   -   5        $��radioServisObrisi��5   �   $��Italic$�6M   $��13(�6`   $��DemiBold"�6n   $ 	operacija��6�   $	��100��6�   $��30��6�   $��560,70,40,341q�6�   $��1��6�   $��Center=�6�   	 6   �� *RadioObrisi+$ OneWayToSource=�.��6  Obrisi5      �� 5    
   -   5        $��btnServisOp��5    N   $��13(�6   $��DemiBold"�6   
���2͚�$��1��6a   $��Izvrsi operaciju��6n   $��560,101,20,300q�6�   ��6�   �� *KomandaIzvrsi+�� 5!   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��JMBG: ��6G   $��1��6X   $��30��6e   $
��Left=�6q   $	��Top=�6�   $��	10,10,0,0q�6�   �� 5"   
   $��Italic$�6   $��13(�6#   $��DemiBold"�61   $��Deo: ��6G   $��1��6W   $��30��6d   $
��Left=�6p   $	��Top=�6�   $��	10,40,0,0q�6�   �� 5$   
   $��13(�6   $��1��6!   $��30��6.   $��Center=�6:   $
��Left=�6\   $	��Top=�6w   $	��170��5&   L   $��
105,10,0,0q�6X   ��5%      �� *	majstorii+$ PropertyChanged=� 5&      �� *Izabran.MajstorJMBG+$ TwoWay=�6X   �� 5'   
   $��13(�6   $��1��6!   $��30��6.   $��Center=�6:   $
��Left=�6\   $	��Top=�6w   $	��170��5)   I   $��
105,40,0,0q�6U   ��5(      �� *Delovi+$ PropertyChanged=� 5)      �� *Izabran.DeoDEOID+$ TwoWay=�6U   5*      5+      