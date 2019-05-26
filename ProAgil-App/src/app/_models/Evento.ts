import { Lote } from "./Lote";
import { Palestrante  } from "./Palestrante";
import { RedeSocial } from "./RedeSocial";

export interface Evento {
    id: string;
    local: string;
    dataEvento: Date;
    tema: string;
    qtdPessoas: number;
    imgUrl: string;
    telefone: string;
    email: string;
    redesSociais: RedeSocial[];
    palestranteEventos: Palestrante[];
    lotes: Lote[];
}
