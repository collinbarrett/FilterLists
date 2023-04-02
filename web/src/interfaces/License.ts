export interface License {
  id: number;
  name: string;
  url: string;
  permitsModification: boolean;
  permitsDistribution: boolean;
  permitsCommercialUse: boolean;
  filterListIds: number[];
}
