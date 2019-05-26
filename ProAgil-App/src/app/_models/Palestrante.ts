import { RedeSocial } from "./RedeSocial";
import { Evento } from "./Evento";

export interface Palestrante {
     id: number;
     nome: string;
     miniCurriculo: string;
     imgUrl: string;
     telefone: string;
     email: string;
     redesSociais: RedeSocial[];
     palestranteEvento: Evento[];
}