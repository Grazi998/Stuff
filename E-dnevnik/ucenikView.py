from bottle import  template

class UcenikView():
    
    @staticmethod
    def o_osobni_ocjene(ocjene,podaci=[]):
        return template('Ucenik_naslovna',podaci=podaci,ocjene=ocjene)
