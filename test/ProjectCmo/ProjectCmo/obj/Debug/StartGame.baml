   M S B A M L   `   `   `  ����E  AProjectCmo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjectCmo
ProjectCmo  5   	       ProjectCmo.StartGame   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjectCmo     5   	     � Title$  Start New Game��5   	   $	��345��6    $	��445��6-    � 
ResizeMode$ NoResize=�69   .��5	      �  � RowDefinitions 5
   
   �� 5      $��58 �6   �� 5      $��20 �6   �� 5      �� 5      $��42 �6   .+�5   
   �� $��0��6   ���#C40D42.+�5      ��  �� Left$ 10��5      
 �� Top$ 13��5      $��New Game��5      ���	#FFF7EFEF$��Times New Roman)�5      $��24(�5      $
��Bold"�5      5      �� 5   
   $��1��6   ���#C40D425      �� 5   
   $��3��5   	    �� Orientation$ 
Horizontal=�5   	   $��RightToLeft=�5    	   .+�5"      �� -   5        $��cancelButton��5&      $��_Cancel��5"      $��22��5#      $��75��5$      $��10,0,0,0q�5%      5'      �� 5)      -   5        $��okButton��5-      $	��_OK��5)      $��22��5*      $��75��5+      $��10,0,0,0q�5,      {�.  5/      51      �� 53   
   -   5         ��Name$ label��53      $��Players��54      $
��Left=�55      $��10,5,0,0q�56      $��2��57      $	��Top=�58      �� 5:   
   -   5        $ label1��5:      $��
New Player��5;      $
��Left=�5<      $��	252,0,0,0q�5=      $��2��5>      $	��Top=�5?      �� 5A   
   -   5         ��Name$ playerNamesListBox��5A      $
��Left=�5B      $	��155��5C      $��	10,31,0,0q�5D      $��2��5E      $	��Top=�5F      $	��227��5G      ��5H      ��  �� Path$ PlayerNames�5I      �� 5K   
   -   5        	 ��Name$	 addNewPlayerButton��5K      $	��Add��5L      $
��Left=�6   $��
354,59,0,0q�5M      $��2��5N      $	��Top=�5O      $��64��5P      5Q      �� 5S   
   -   5        
 ��Name$
 newPlayerTextBox��5S      $
��Left=�5T      $��23��5U      $��
252,31,0,0q�5V      $��2��5W       �� TextWrapping$
 Wrap=�5X      $	��Top=�5Y      $	��166��5Z      5[      5]      