   M S B A M L   `   `   `  ����G  CJogoForcaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:JogoForcaWPFJogoForcaWPF  5   	       JogoForcaWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:JogoForcaWPF     5   	     � Title$  
MainWindow��5   	   $	��343��6   $	��600��6)   
�������.��5      � $��Center=�6   $	��600��6(   $	��325��64   $	��Top=�6A    � RowDefinitions 5   
   �� 5      .+�5   
   �� $��Jogo da Forca��6   $��	0,0,194,0q�6(   $	��Top=�6;   $��30(�6S   $��arial)�6a   $��Right=�6t   $	��202��6�   �� 5   
   $ ��Escreva a palavra secreta:��6   $��Center=�65   $	��Top=�6R   $��0,46,0,0q�6j   �� 5   
   -   5         ��Name$ 
ttbPalavra��5       �� CharacterCasing$ Upper=�6&   $��0,70,0,0q�6>   $	��300��6P   $��25��6\   $��10��6h   $��Center=�6w   $	��Top=�6�   
�������$��Center=�6�   $��16(�6�   $��1��6�   �� 5   
   -   5        $ ttbChave��5       �� TextWrapping$
 Wrap=�6$   $��Center=�68   $�� ��6\   $	��400��6d   $��30��6p   $��18(�6|   $��Black"�6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5         ��Name$ 
btnPalavra��5      $��	0,106,0,0q�66   $��Criar palavra��6I   
��� ���
��� ���$��24��6�   
�������$	��Top=�6�   $��Center=�6�   $��78��6�   �� 5   
   -   5         ��Name$ lblRestantes��5   -   $��Chances restantes:��6   $��0,0,463,248q�6C   $��Right=�6X   $	��127��6t   $��45��6�   $��Bottom=�6�   �� 5   
   -   5        $ 
lblChances��5      $��12��6$   $��	17,44,0,0q�61   $��75(�6D   $��98��6R   $	��Top=�6^   $
��Left=�6v   $��96��6�   �� 5   
   $��Digite uma letra:��6   $
��Left=�6,   $��Bottom=�6G   $��
106,0,0,89q�6b   �� 5   
   -   5        $ 	ttbLetras��5       �� 	MaxLength$ 1��6%   $	��250��63   $��22��6?   $��0,241,320,0q�6K   $ Upper=�6`   $��Right=�6x   $	��Top=�6�    � OverridesDefaultStyle$ False��6�   $��Center=�6�   $��2��6�   �� 5   
   -   5        $ btnLetra��5      $��0,268,406,0q�69   $��Enviar letra��6N   
��� ���
��� ���$��25��6�   
�������$	��Top=�6�   $��Right=�6�   $��78��6�   �� 5   
   -   5        	 ��Name$	 ttbList��5   '   
�������$��406,223,0,32q�68   $
��Left=�6N   $	��170��6i   $
��Wrap=�6u   �� 5   
   $��Letras que já foram��6   $��432,190,0,0q�6.   $
��Left=�6C   $	��118��6^   $��28��6j   $	��Top=�6v   5      5      