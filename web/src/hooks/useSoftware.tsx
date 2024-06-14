import { Software } from "../interfaces/Software";
import { useApiData } from "./useApiData";

export const useSoftware = () =>
  (useApiData<Software[]>("https://api.filterlists.com/software") || []).sort(
    (a: Software, b: Software) => a.name.localeCompare(b.name),
  );
