   M S B A M L   `   `   `  ����C  ?CardsGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CardsGUICardsGUI  5   	       CardsGUI.GameClient   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CardsGUI     5   	     � Title$  Cripple Mr.Onion��5   	    � WindowState$ 	Maximized=�6"    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Close��5      5      .��5      � 
��� � � � RowDefinitions 5   
   �� 5      $��58 �6   �� 5      $��20 �6   �� 5      �� 5      $��42 �6   .+�5   
   �� $��0��6   ���#C40D42.+�5      ��  �� Right$ 0��5      $��56��5      $��UniformToFill=�5      $!��.\Images\CrippleMrOnion.jpg��5      �� 5      $��Cripple Mr.Onion   ��5      
 �� Top$ 7��5       �� Left$ 0��5       
���   �$��Tahoma)�5"      $��28(�5#      $��	ExtraBold"�5$      $��Oblique$�5%      5'      ]� 5(   
   $��1��6   $��0q�6!   .+�5)      o� 
��� � �$
��Bold"�6&   
�������.@�5*      m� $��_File��6   .@�5+      m� $��_Start New Game!��5,      $��22��5-      $	��200��5.      
���   �5/      m� 51      $��_Close��52      $	��200��53      
���   � m� Command$ Close��55      56      m� 57      $��_Tools��58      
��� � �
�������.@�5;      m� $��_Options��5<      $
��Left=�5=      $	��200��5>      
���   �5?      5A      m� 5B      $
��Help��5C      
��� � �
�������.@�5F      m� $��_About��5G      $
��Left=�5H      $	��145��5I      
���   �5J      5M      5O      5P      5S      5T      