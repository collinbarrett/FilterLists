import { useEffect, useState } from 'react';

export const useApiData = <T extends {}>(url: string) => {
    const [data, setData] = useState<T>();
    const fetchData = async () => {
        (await fetch(url))
            .json()
            .then(r => setData(r));
    };
    useEffect(() => { fetchData(); }, []);
    return data;
};
