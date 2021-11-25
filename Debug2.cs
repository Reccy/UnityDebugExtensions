using UnityEngine;

namespace Reccy.DebugExtensions
{
    public static class Debug2
    {
        public static void DrawCross(Vector2Int pos)
        {
            DrawCross((Vector3Int)pos);
        }

        public static void DrawCross(Vector3 pos)
        {
            DrawCross(pos, Color.red);
        }

        public static void DrawCross(Vector2Int pos, Color col)
        {
            DrawCross((Vector3Int)pos, col);
        }

        public static void DrawCross(Vector3 pos, Color col)
        {
            DrawCross(pos, col, 0.2f);
        }

        public static void DrawCross(Vector2Int pos, Color col, float scale)
        {
            DrawCross((Vector3Int)pos, col, scale);
        }

        public static void DrawCross(Vector3 pos, Color col, float scale)
        {
            Vector3 topLeft = pos + (Vector3.left * scale) + (Vector3.up * scale);
            Vector3 topRight = pos + (Vector3.right * scale) + (Vector3.up * scale);
            Vector3 botLeft = pos + (Vector3.left * scale) + (Vector3.down * scale);
            Vector3 botRight = pos + (Vector3.right * scale) + (Vector3.down * scale);

            Debug.DrawLine(topLeft, botRight, col);
            Debug.DrawLine(topRight, botLeft, col);
        }

        public static void DrawArrow(Ray ray, float distance)
        {
            DrawArrow(ray, distance, Color.red);
        }

        public static void DrawArrow(Ray ray, float distance, Color col)
        {
            DrawArrow(ray, distance, col, 0.2f);
        }

        public static void DrawArrow(Ray ray, float distance, Color col, float arrowheadSize)
        {
            DrawArrow(ray.origin, ray.origin + ray.direction * distance, col, arrowheadSize);
        }

        public static void DrawArrow(Vector2Int arrowOrigin, Vector2Int arrowTarget)
        {
            DrawArrow((Vector3Int)arrowOrigin, (Vector3Int)arrowTarget, Color.red);
        }

        public static void DrawArrow(Vector3 arrowOrigin, Vector3 arrowTarget)
        {
            DrawArrow(arrowOrigin, arrowTarget, Color.red);
        }

        public static void DrawArrow(Vector2Int arrowOrigin, Vector2Int arrowTarget, Color col)
        {
            DrawArrow((Vector3Int)arrowOrigin, (Vector3Int)arrowTarget, col, 0.2f);
        }

        public static void DrawArrow(Vector3 arrowOrigin, Vector3 arrowTarget, Color col)
        {
            DrawArrow(arrowOrigin, arrowTarget, col, 0.2f);
        }

        public static void DrawArrow(Vector2Int arrowOrigin, Vector2Int arrowTarget, Color col, float arrowheadSize)
        {
            DrawArrow((Vector3Int)arrowOrigin, (Vector3Int)arrowTarget, col, arrowheadSize);
        }

        public static void DrawArrow(Vector3 arrowOrigin, Vector3 arrowTarget, Color col, float arrowheadSize)
        {
            Vector3 beginToEnd = (arrowTarget - arrowOrigin).normalized;

            Vector2 perp = Vector2.Perpendicular(beginToEnd);

            Debug.DrawLine(arrowOrigin, arrowTarget, col);
            Debug.DrawLine(arrowTarget, arrowTarget - (beginToEnd * arrowheadSize) + (Vector3)(perp * arrowheadSize), col);
            Debug.DrawLine(arrowTarget, arrowTarget - (beginToEnd * arrowheadSize) - (Vector3)(perp * arrowheadSize), col);
        }

        public static void DrawBounds(Bounds bounds)
        {
            Debug.DrawLine(new Vector3(bounds.min.x, bounds.min.y), new Vector3(bounds.min.x, bounds.max.y), Color.blue);
            Debug.DrawLine(new Vector3(bounds.min.x, bounds.max.y), new Vector3(bounds.max.x, bounds.max.y), Color.blue);
            Debug.DrawLine(new Vector3(bounds.max.x, bounds.max.y), new Vector3(bounds.max.x, bounds.min.y), Color.blue);
            Debug.DrawLine(new Vector3(bounds.max.x, bounds.min.y), new Vector3(bounds.min.x, bounds.min.y), Color.blue);
        }

        public static void DrawBounds(BoundsInt bounds)
        {
            Bounds b = new Bounds(bounds.center, bounds.size);
            DrawBounds(b);
        }
    }
}
