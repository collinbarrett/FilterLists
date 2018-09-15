export interface IListDto {
    id: number;
    languages: IListLanguageDto[];
    name: string;
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