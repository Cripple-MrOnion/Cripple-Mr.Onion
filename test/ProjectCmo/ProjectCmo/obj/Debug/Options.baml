   M S B A M L   `   `   `  ����E  AProjectCmo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjectCmo
ProjectCmo  5   	       ProjectCmo.Options   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjectCmo     5   	     � Title$  Options��5   	   $	��345��6   $	��434��6&    � 
ResizeMode$ NoResize=�62   .��5      �  � RowDefinitions 5   
   �� 5      $��58 �6   �� 5      $��20 �6   �� 5      �� 5      $��42 �6   .+�5   
   �� $��0��6   ���#C40D42.+�5      �� $��Add Players��5      
 �� Top$ 13��5       �� Left$ 10��5      
�������$��Times New Roman)�5      $��24(�5      $
��Bold"�5      5      �� 5   
   $��1��6   ���#C40D42 � 	Resources 5          ProjectCmo.NumberOfPlayers   numberOfPlayersData��%   &	          5       6(   5!      .+�5"      �� $ 10��6   $ 2��6+   $	��408��6:   $	��208��6F   .@�5#      �� $
��Game��6   .��5$      � ���	#FFE5E5E5 � ColumnDefinitions 5%      �� 5&      $	��37* �6/   �� 5'      $	��97* �6/   .+�5*      �� $��Number of players��6    $
��Left=�6<   $��	10,54,0,0q�5+      $	��Top=�6   $��2��6,   �� 5,      -   5        $��numberOfPlayersComboBox��50      $
��Left=�5,   #   $��84.525,58,0,0q�5-      $	��Top=�5.      $��86��5/      $��1��53      ��51      ��  �� Source# [   �� SelectedValue 52      �� 	 �� Path$	 NumberOfPlayers�53      54      55      57      58      �� 59   
   $��3��6   
 �� Orientation$
 
Horizontal=�6"   $��RightToLeft=�6;   .+�5:      �� -   5        $��cancelButton��5;      $��_Cancel��5:      $��22��6'   $��75��63   $��10,0,0,0q�6>   5;   #   �� 5<      -   5        $��okButton��5=      $	��_OK��5<      $��22��6#   $��75��6/   $��10,0,0,0q�6:   5=      5>      5?      5@      