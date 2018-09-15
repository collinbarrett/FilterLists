export interface IListDto {
    id: number;
    name: string;
    languages: IListLanguageDto[];
    softwareIds: number[];
    tags: IListTagDto[];
    updatedDate: string;
}

interface IListLanguageDto {
    name: string;
    iso6391: string;
}

interface IListTagDto {
    name: string;
    colorHex: string;
    description: string;
}