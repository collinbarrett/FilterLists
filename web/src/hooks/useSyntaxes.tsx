import { Syntax } from "../interfaces/Syntax";
import { useApiData } from "./useApiData";

export const useSyntaxes = () =>
  (useApiData<Syntax[]>("https://api.filterlists.com/syntaxes") || []).sort(
    (a: Syntax, b: Syntax) => a.name.localeCompare(b.name),
  );
