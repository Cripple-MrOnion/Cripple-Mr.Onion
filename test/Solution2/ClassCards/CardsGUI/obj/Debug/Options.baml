   M S B A M L   `   `   `  ����C  ?CardsGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CardsGUICardsGUI  5   	       CardsGUI.Options   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CardsGUI     5   	     � Title$  Options��5   	   $	��345��6   $	��434��6&    � 
ResizeMode$ NoResize=�62   .��5
      �  � RowDefinitions 5   
   �� 5      $��58 �6   �� 5      $��20 �6   �� 5      �� 5      $��42 �6   .+�5   
   �� $��0��6   ���#c40d42.+�5      �� $��Add Players��5      
 �� Top$ 13��5       �� Left$ 10��5      
�������$��Times New Roman)�5      $��24(�5      $
��Bold"�5      5      �� 5   
   $��1��6   
������� � 	Resources 5         CardsGUI.NumberOfPlayers   numberOfPlayersData��%   &	          5      6(   5       .+�5!      �� $ 10��5"      $ 2��5#      $	��408��5$      $	��208��5%      .@�5'      �� $
��Game��6   .��5(      � ���	#FFE5E5E5.+�5)      �� $��Number of players��5*      $
��Left=�5+      $��	10,10,0,0q�5,      $	��Top=�5-      �� 5/      -   5        $��numberOfPlayersComboBox��54      $
��Left=�50      $��
125,10,0,0q�51      $	��Top=�52      $��86��53      ��55      ��  �� Source# [   �� SelectedValue 56      ��  �� Path$ NumberOfPlayers�58      59      5:      5;      �� 5=   
   $��3��6   	 �� Orientation$	 
Horizontal=�6"   $��RightToLeft=�6;   .+�5>      �� -   5        $��cancelButton��5C      $��_Cancel��5?      $��22��5@      $��75��5A      $��10,0,0,0q�5B      5C   %   �� 5E      -   5        $��okButton��5J      $	��_OK��5F      $��22��5G      $��75��5H      $��10,0,0,0q�5I      5J   !   5L      5O      5P      