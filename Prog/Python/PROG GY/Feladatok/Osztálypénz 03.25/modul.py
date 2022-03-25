class Tanulo:
    def __init__(self, neve, iszm, tel, kozt, koztje, hzszam, penz):
        self.neve = neve
        self.penz = int(penz)
        self.lakcim = f'{iszm} {tel}, {kozt}, {koztje}, {hzszam}'
        