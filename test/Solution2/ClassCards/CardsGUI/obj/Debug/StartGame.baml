   M S B A M L   `   `   `  ����C  ?CardsGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CardsGUICardsGUI  5   	       CardsGUI.StartGame   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CardsGUI     5   	     � Title$  Start New game��5   	   $	��300��6    $	��445��6-    � 
ResizeMode$ NoResize=�69   .��5
      �  � RowDefinitions 5   
   �� 5      $��58 �6   �� 5      $��20 �6   �� 5      �� 5      $��42 �6   .+�5   
   �� $��0��6   ���#c40d42.+�5      �� $��New Game��5      
 �� Top$ 13��5       �� Left$ 10��5      
�������$��Times New Roman)�5      $��24(�5      $
��Bold"�5      5      �� 5   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��RightToLeft=�6;   .+�5      �� -   5        $��cancelButton��5$      $��_Cancel��5       $��22��5!      $��75��5"      $��10,0,0,0q�5#      5%      �� 5'      -   5        $��okButton��5,      $	��_OK��5(      $��22��5)      $��75��5*      $��10,0,0,0q�5+      5-      5/      �� 50   
   -   5         ��Name$ label��51      $��Players��52      $
��Left=�53      $	��Top=�54      $��5,60,0,0q�55      $��2��56      �� 58   
   -   5        $ label1��59      $��
New Player��5:      $
��Left=�5;      $	��Top=�5<      $��5,0,0,0q�5=      $��2��5>      �� 5@   
   -   5         ��Name$ playerNamesListBox��5A      $
��Left=�5B      $	��Top=�5C      $	��166��5D      $��50��5E      $��5,85,0,0q�5F      $��2��5G      ��5H      ��  �� Path$ PlayerNames��� 5J   
   -   5        	 ��Name$	 addNewPlayerButton��5K      $	��Add��5L      $
��Left=�5M      $	��Top=�5N      $��64��5O      $��
180,32,0,0q�5P      $��2��5Q      5R      �� 5T   
   -   5        
 ��Name$
 newPlayerTextBox��5U      $
��Left=�5V      $	��Top=�5W      $	��166��5X      $��23��5Y      $��5,31,0,0q�5Z      $��2��5[       �� TextWrapping$
 Wrap=�5\      5^      5_      