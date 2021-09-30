using UnityEngine;

namespace Reccy.DebugExtensions
{
    public static class Debug2
    {
        public static void DrawCross(Vector2 pos)
        {
            DrawCross(pos, Color.red);
        }

        public static void DrawCross(Vector2 pos, Color col)
        {
            DrawCross(pos, col, 0.2f);
        }

        public static void DrawCross(Vector2 pos, Color col, float scale)
        {
            Vector3 topLeft = pos + (Vector2.left * scale) + (Vector2.up * scale);
            Vector3 topRight = pos + (Vector2.right * scale) + (Vector2.up * scale);
            Vector3 botLeft = pos + (Vector2.left * scale) + (Vector2.down * scale);
            Vector3 botRight = pos + (Vector2.right * scale) + (Vector2.down * scale);

            Debug.DrawLine(topLeft, botRight, col);
            Debug.DrawLine(topRight, botLeft, col);
        }

        public static void DrawArrow(Vector2 arrowOrigin, Vector2 arrowTarget)
        {
            DrawArrow(arrowOrigin, arrowTarget, Color.red);
        }

        public static void DrawArrow(Vector2 arrowOrigin, Vector2 arrowTarget, Color col)
        {
            DrawArrow(arrowOrigin, arrowTarget, col, 0.2f);
        }

        public static void DrawArrow(Vector2 arrowOrigin, Vector2 arrowTarget, Color col, float arrowheadSize)
        {
            Vector2 beginToEnd = (arrowTarget - arrowOrigin).normalized;

            Vector2 perp = Vector2.Perpendicular(beginToEnd);

            Debug.DrawLine(arrowOrigin, arrowTarget, col);
            Debug.DrawLine(arrowTarget, arrowTarget - (beginToEnd * arrowheadSize) + (perp * arrowheadSize), col);
            Debug.DrawLine(arrowTarget, arrowTarget - (beginToEnd * arrowheadSize) - (perp * arrowheadSize), col);
        }

        public static void DrawBounds(Bounds bounds)
        {
            Debug.DrawLine(new Vector3(bounds.min.x, bounds.min.y), new Vector3(bounds.min.x, bounds.max.y), Color.blue);
            Debug.DrawLine(new Vector3(bounds.min.x, bounds.max.y), new Vector3(bounds.max.x, bounds.max.y), Color.blue);
            Debug.DrawLine(new Vector3(bounds.max.x, bounds.max.y), new Vector3(bounds.max.x, bounds.min.y), Color.blue);
            Debug.DrawLine(new Vector3(bounds.max.x, bounds.min.y), new Vector3(bounds.min.x, bounds.min.y), Color.blue);
        }
    }
}
