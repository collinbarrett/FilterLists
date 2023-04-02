import { Software } from "../interfaces/Software";
import { useApiData } from "./useApiData";

export const useSoftware = () =>
  (useApiData<Software[]>("/api/software") || []).sort(
    (a: Software, b: Software) => a.name.localeCompare(b.name)
  );
