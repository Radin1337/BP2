   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClientClient  5   	   )clr-namespace:Client.ViewClient.View  5   	   3clr-namespace:Client.ViewModelClient.ViewModel  5   	       Client.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Client     5   	   *viewclr-namespace:Client.View     5   	   4	viewModelclr-namespace:Client.ViewModel     5   	   -   5          � Title$  
Evidencija��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � Icon$ /Resources/ico.png��6K    � 	Resources 5       �� DataType&    Client.ViewModel.ServisViewModel   Client.View.ServisView(   "Client.ViewModel.ServiserViewModel   Client.View.ServiserView-   'Client.ViewModel.DijagnosticarViewModel#   Client.View.DijagnosticarView'   !Client.ViewModel.MajstorViewModel   Client.View.MajstorView)	   #Client.ViewModel.AutomobilViewModel
   Client.View.AutomobilView#   Client.ViewModel.SusViewModel   Client.View.SusView*   $Client.ViewModel.ElektricniViewModel    Client.View.ElektricniView'   !Client.ViewModel.PregledViewModel   Client.View.PregledView(   "Client.ViewModel.PokvarenViewModel   Client.View.PokvarenView#   Client.ViewModel.DeoViewModel   Client.View.DeoView)   #Client.ViewModel.MajstorZaViewModel   Client.View.MajstorZaView*   $Client.ViewModel.PopravljenViewModel    Client.View.PopravljenView��%�  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5      *,	 +)(�� �     5      *, +)(�� ,    5      *, +)(�� ^    5"      *, +)(�� �    5%      *, +)(�� �    5(      *, +)(�� �    5+      *, +)(�� &    5.      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   " 	 6   .R�5      
  5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5         5!      �� 5"   
   "  6   .R�5#        5$      �� 5%   
   "  6   .R�5&        5'      �� 5(   
   "  6   .R�5)        5*      �� 5+   
   "  6   .R�5,        5-      �� 5.   
   "  6   .R�5/        50      51       � DataContext 52          Client.MainWindowViewModel  53   
   .��55      � 
����ح�.+�56   
   �� $
��Left=�6   $	��100��60   $	��411��6<   $��Bottom=�6I   .+�57      �� -   5         ��Name$ ServisButton��57   R   $��13(�6   $��DemiBold"�6#   
���2͚�$��Servisi��6h   $��34��6z   $	��Top=�6�   $	��100��6�   $��Servis��6�   ��6�   �� *buttonClick+6�   �� 58      -   5        $ ServiserButton��58   R   $��13(�6   $��DemiBold"�6#   
���2͚�$��	Serviseri��6j   $��34��6~   $	��Top=�6�   $	��100��6�   $��Serviser��6�   ��6�   �� *buttonClick+6�   �� 59      -   5        $ MajstorButton��59   R   $��13(�6   $��DemiBold"�6#   
���2͚�$��Majstori��6i   $��34��6|   $	��Top=�6�   $	��100��6�   $��Majstor��6�   ��6�   �� *buttonClick+6�   �� 5:      -   5        $ DijagnosticarButton��5:   R   $��13(�6   $��DemiBold"�6#   
���2͚�$��Dijagnosticari��6o   $��34��6�   $	��Top=�6�   $	��100��6�   $��Dijagnosticar��6�   ��6�   �� *buttonClick+6�   �� 5;      -   5        $ AutomobilButton��5;   R   $��13(�6   $��DemiBold"�6#   
���2͚�$��
Automobili��6k   $��34��6�   $	��Top=�6�   $	��100��6�   $��	Automobil��6�   ��6�   �� *buttonClick+6�   �� 5<      -   5        $ 	SusButton��5<   R   $��13(�6   $��DemiBold"�6#   
���2͚�$	��SUS��6e   $��34��6s   $	��Top=�6   $	��100��6�   $	��Sus��6�   ��6�   �� *buttonClick+6�   �� 5=      -   5        $ ElektricniButton��5=   R   $��13(�6   $��DemiBold"�6#   
���2͚�$��
Elektricni��6l   $��34��6�   $	��Top=�6�   $	��100��6�   $��
Elektricni��6�   ��6�   �� *buttonClick+6�   �� 5>      -	   5        $ PregledButton��5>   R   $��13(�6   $��DemiBold"�6#   
���2͚�$��Pregledi��6i   $��34��6|   $	��Top=�6�   $	��100��6�   $��Pregled��6�   ��6�   �� *buttonClick+6�   �� 5?      -
   5        $ PokvarenButton��5?   R   $��13(�6   $��DemiBold"�6#   
���2͚�$��	Pokvareni��6j   $��34��6~   $	��Top=�6�   $	��100��6�   $��Pokvaren��6�   ��6�   �� *buttonClick+6�   �� 5@      -   5        $ 	DeoButton��5@   R   $��13(�6   $��DemiBold"�6#   
���2͚�$��Delovi��6e   $��34��6v   $	��Top=�6�   $	��100��6�   $	��Deo��6�   ��6�   �� *buttonClick+6�   �� 5A      -   5        $ MajstorZaButton��5A   R   $��13(�6   $��DemiBold"�6#   
���2͚�$��Majstori za deo��6k   $��34��6�   $	��Top=�6�   $	��100��6�   $��	MajstorZa��6�   ��6�   �� *buttonClick+6�   �� 5B      -   5        $ PopravljenButton��5B   R   $��13(�6   $��DemiBold"�6#   
���2͚�$��Popravljeni��6l   $��34��6�   $	��Top=�6�   $	��100��6�   $��
Popravljen��6�   ��6�   �� *buttonClick+6�   5C      �� 5E   
   ��6   �� *CurrentViewModel+ �� Mode$ OneWay=�5F      5G      