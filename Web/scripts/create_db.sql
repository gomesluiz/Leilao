-- SQLite
CREATE TABLE usuarios
(
    id      INTEGER PRIMARY KEY,
    nome    TEXT NOT NULL
)
;
CREATE TABLE leiloes
(
    id           INTEGER PRIMARY KEY,
    descricao    TEXT NOT NULL
)
;
CREATE TABLE lances
(
    id          INTEGER PRIMARY KEY,
    leilao_id   INTEGER NOT NULL,
    usuario_id  INTEGER NOT NULL,
    valor       REAL NOT NULL,

    FOREIGN KEY (leilao_id)
        REFERENCES leiloes(id),

    FOREIGN KEY (usuario_id)
        REFERENCES usuarios(id)
)
;
