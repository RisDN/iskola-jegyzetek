vonal = '-----------------------------------'
print(vonal)
ar = int(input('Kérlek add meg a termék árát: '))
mennyiseg = int(input('Kérlek add meg a termék mennyiségét: '))
egyenleg = int(input('Kérlek add meg mennyi pénzed van: '))
fizetendo = ar * mennyiseg
print(vonal)
if egyenleg >= fizetendo:
  marad = egyenleg - fizetendo
  print('Meg tudod venni a ', mennyiseg, ' darabot.\nEnnyi pénzed marad: ', marad, 'Ft')
else:
  teljes_ar = mennyiseg * ar
  print('Nincs elég pénzed!', '\nEnnyire van szükség: ', teljes_ar, 'Ft\nDe tudsz venni ', int(egyenleg / teljes_ar), ' darabot!')
print(vonal)