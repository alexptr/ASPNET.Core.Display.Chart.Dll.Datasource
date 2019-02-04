import { ChartPoint } from './chartPoints';

export interface ChartSeries {
    id: string;
    name: string;
    points: ChartPoint[];

}
