   M S B A M L   `   `   `  ����E  AProjectCmo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjectCmo
ProjectCmo  5   	       ProjectCmo.GameClient   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjectCmo     5   	     � Title$	  CMO��5   	    � WindowStyle$
 None=�6    � 
ResizeMode$ NoResize=�6(    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowState$ 	Maximized=�6.    � DataContext 5
         ProjectCmo.GameViewModel  5   
    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Close��5      5   (     5   
   -   5        $* $local:GameViewModel.StartGameCommand��5      5         5   
   -   5        $* $local:GameViewModel.ShowAboutCommand��5      5         5   
   -   5        $&  local:GameOptions.OptionsCommand��5      5       .��5      � 
��� � � � RowDefinitions 5   
   �� 5      $��58 �6   �� 5      $��20 �6   �� 5      �� 5      $��42 �6   .+�5    
   �� $��0��6   ���#C40D42.+�5"      �� 	 �� Right$	 0��5#      $��56��5$      $��UniformToFill=�5%      $!��.\Images\CrippleMrOnion.jpg��5&      �� 5'      $��Cripple Mr.Onion   ��5(      

 �� Top$
 7��5)       �� Left$ 0��5*      
���   �$��Tahoma)�5,      $��28(�5-      $��	ExtraBold"�5.      $��Oblique$�5/      52      ]� 53   
   $��0q�6   $��1��6   .+�54      o� 
��� � �$
��Bold"�6&   
�������.@�55      m� $��_File��6   .@�56      m� $��_New Game...��6   
���   �$	��200��6H    m� Command$* $local:GameViewModel.StartGameCommand��6T   �� 57      $	��145��6    
���   �6,   m� 58      $��_Close��6   $	��200��6/   
���   �$ Close��6N   59      m� 5;      $��_Tools��6   
��� � �
�������.@�5<      m� $��_Options��6   $
��Left=�61   $	��200��6L   
���   �$&  local:GameOptions.OptionsCommand��6k   5=      m� 5>      $
��Help��6   
��� � �
�������.@�5?      m� $��_About��6   $
��Left=�6/   $	��145��6J   
���   �$* $local:GameViewModel.ShowAboutCommand��6i   5A      5B      5C      ]� 5D   
   $��2��6   .+�5E      #   ProjectCmo.CardsInHandControl  -   5          Name$ Player2Hand��5E   '   $��Right=�6<   $	��380��5F      $��Center=�5G      $	��180��6&      PlayerOrientation$ Vertical=�62      Game 5F      ��    Owner 5H      �� *
Players[1]+   PlayerState 6(   �� *Players[1].State+  5I      -   5        $ Player4Hand��5I   '   $
��Left=�6<   $
��Left=�5J      $	��380��6&   $��Center=�63   $ Vertical=�5K      $	��180��6E    6(   �� *
Players[3]+ 5L      �� *Players[3].State+ 64   ��   5M      -   5        $ Player1Hand��5M   '   $	��Top=�6<   $��Center=�5N      $	��154��6(   $	��Top=�65   $ 
Horizontal=�5O      $	��380��6G    6*   �� *
Players[0]+ 5P      �� *Players[0].State+ 64   ��   5Q      -   5        $ Player3Hand��5Q   '   $��Bottom=�6<   $��Center=�5R      $	��154��6(   $	��Top=�65   $ 
Horizontal=�5S      $	��380��6G    6*   �� *
Players[2]+ 5T      �� *Players[2].State+ 64   �� !   ProjectCmo.GameDecksControl  5U      -	   5          Name$ 	GameDecks��5U   2   $	��180��6%      Deck 6E   �� *
GameDeck+   AvailableCard 5V      �� *CurrentAvailableCard+   CurrentPlayer 5W      �� *CurrentPlayer+   GameStarted 5X      �� *GameStarted+5Y      5[      5\      