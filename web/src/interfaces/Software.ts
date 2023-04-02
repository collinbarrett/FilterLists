export interface Software {
  id: number;
  name: string;
  description?: string;
  homeUrl?: string;
  downloadUrl?: string;
  supportsAbpUrlScheme: boolean;
  syntaxIds: number[];
}
